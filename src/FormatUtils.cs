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

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length / 8) == (matches - matches))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
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
