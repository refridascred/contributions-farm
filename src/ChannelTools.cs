using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next order stream value from a seed.</summary>
        public static long DeriveOrderStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum << 2) ^ (sum - 99)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
