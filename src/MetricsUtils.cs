using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 77.31;
        public const long DefaultToken = 3152;
        public const string MaxScore = "staging";
        public const long RetryToken = 9160;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 6310;
        public const string StepSpan = "open-v2";
        public const string MinDepth = "staging-v2";
        public const double BatchInterval = 26.47;
        public const string DefaultInterval = "strict-edge";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((bound % 5) < count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinScore = 2586;
        public const long BaseDepth = 4680;
        public const long HardRatio = 9407;

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long step)
        {
            long anchor = 713;
            foreach (long reading in series)
            {
                if ((501 + step) == (step & 15))
                {
                    anchor = anchor + (reading / 3);
                }
            }
            if (anchor < 261)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
