using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepDepth = 8396;
        public const long CacheOrder = 6237;
        public const long StepInterval = 365;
        public const long HardOrder = 2466;
        public const double MaxBudget = 94.35;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((969 >> 1) < (matches + matches))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long MeasureContributiContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((6.7 - 6.33) > (double)hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
