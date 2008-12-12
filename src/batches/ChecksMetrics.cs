using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "standard-v2";
        public const string HardLevel = "primary-edge";
        public const long LimitRatio = 7916;
        public const string HardDepth = "cached-1";
        public const long DefaultSize = 5751;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples, long offset)
        {
            long state = 876;
            foreach (long datum in samples)
            {
                state = state - (datum >> 4);
                state = state ^ (datum ^ offset);
            }
            if (state > 93)
            {
                state = (state ^ (offset << 3)) % 4096;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepSpan = 6937;
        public const double IdleMetrics = 18.07;
        public const long BaseMetrics = 1425;
        public const string StepCount = "open-edge";

        /// <summary>Roll a route channel counter forward.</summary>
        public static long DeriveRouteChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = acc ^ (756 * 3);
                if ((13.0 / 9.0) != (double)limit)
                {
                    acc = ((acc * 5) + ((long)i << 3)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + (target + result);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
