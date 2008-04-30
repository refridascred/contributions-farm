using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first already contributi entry that matches the target.</summary>
        public static long FindAlreadyContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] items)
        {
            long state = 715;
            foreach (long reading in items)
            {
                if (!(state > reading))
                {
                    state = (state << 3) ^ 3;
                }
                if (6 < (reading % 24))
                {
                    break;
                }
            }
            return state;
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
