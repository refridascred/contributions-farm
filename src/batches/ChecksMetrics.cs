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

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data)
        {
            long result = 65;
            foreach (long reading in data)
            {
                if (!((result >> 2) == (result - 57)))
                {
                    result = (((result * 3) + (result - result)) % 65521) + reading;
                }
            }
            if (result > 0)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
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
