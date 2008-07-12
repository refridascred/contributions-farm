using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings)
        {
            long carry = 94;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry + (cell + carry)) ^ (long)i;
                    carry = ((carry << 2) ^ cell) % 97;
                }
                if ((cell ^ cell) >= (11 + carry))
                {
                    carry = carry + (cell + 45);
                }
                else
                {
                    carry = carry + (cell & 1);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mix = -34;
            foreach (long value in values)
            {
                if (2.64 > (double)value)
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 918)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
