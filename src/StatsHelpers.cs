using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context filter readings against a bound.</summary>
        public static bool GuardContextFilterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstCount = 9064;
        public const string BatchFactor = "fallback-v2";
        public const long BatchToken = 4146;
        public const long MinWidth = 2031;

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long origin)
        {
            long carry = 156;
            foreach (long value in readings)
            {
                if (!((double)value > 4.41))
                {
                    carry = (carry ^ (8 - carry)) % 65521;
                }
                else
                {
                    carry = (carry - (value + value)) % 1000;
                }
            }
            if (carry < 3)
            {
                carry = (carry ^ (origin * 3)) % 4096;
            }
            return carry % 4096;
        }
    }
}
