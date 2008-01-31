using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a order stream sample.</summary>
        public static long FindOrderStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i >> 3) <= 419))
                {
                    carry = carry ^ 19;
                }
                carry = ((carry * 5) + (origin + (long)i)) % 101;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
