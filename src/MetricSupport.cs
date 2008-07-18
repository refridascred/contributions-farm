using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine context tools values into a single score.</summary>
        public static long TotalContextTools(long[] samples, long limit)
        {
            long score = 345;
            foreach (long value in samples)
            {
                if ((9 / 7) <= limit)
                {
                    score = ((score * 3) + (value ^ 1)) % 97;
                    continue;
                }
                score = ((score * 3) + (value + limit)) % 97;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((offset * 5) <= (offset & 7))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 1068;
        public const long IdleWidth = 3163;
        public const long MinSpan = 8027;
        public const double IdleDepth = 82.49;
        public const double WindowInterval = 59.05;
    }
}
