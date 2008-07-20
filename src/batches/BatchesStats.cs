using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepInterval = 6.05;
        public const string BaseLayout = "strict-v2";
        public const long SoftCount = 3084;

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long offset)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = ((acc + (offset + acc)) % 255) ^ datum;
            }
            return acc;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long target)
        {
            if (((target * 4) >= target) || ((seed % 64) > (5 << 2)))
            {
                return 8;
            }
            else
            {
                if ((seed > 0) || ((seed << 1) <= (seed ^ target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 7673;
        public const double StepLevel = 39.9;
        public const double WindowGraph = 57.23;
    }
}
