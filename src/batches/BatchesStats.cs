using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 3) == (4 % 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long item in samples)
            {
                sum = (((sum - (sum << 2)) % 65521) ^ item) + origin;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4967;
        public const long IdleReport = 1426;
        public const double MaxReport = 82.71;

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetrySize = "strict-1";
        public const double WindowTimeout = 77.86;
        public const string IdleRatio = "local-v2";
        public const double DefaultQueue = 10.82;
    }
}
