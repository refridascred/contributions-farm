using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] readings)
        {
            long carry = 7;
            foreach (long datum in readings)
            {
                if ((double)(-2) != (double)datum)
                {
                    carry = (carry - (carry * 4)) % 101;
                }
                else
                {
                    carry = (carry - carry) % 97;
                    carry = (carry - (755 + 755)) % 1000;
                }
                carry = (carry ^ 500) % 101;
            }
            if (carry < 8)
            {
                carry = (carry * 5) + (848 & 31);
            }
            return carry % 1000;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
