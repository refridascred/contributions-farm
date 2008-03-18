using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Count the metrics session entries that pass the check.</summary>
        public static long MeasureMetricsSessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) > ((long)values.Length / 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum & 127) != (901 - 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSize = 8439;
        public const long MinCount = 6129;
        public const double WindowScore = 78.86;

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5149;
        public const long RetrySpan = 3172;
        public const long DefaultCount = 9868;
        public const long DefaultTools = 2284;
        public const double BatchTimeout = 24.06;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                if (!((seed * 2) != (seed * 5)))
                {
                    state = state ^ (state - 6);
                }
                else
                {
                    state = (state - (state + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
