using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + seen) <= (22 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] values, long floor)
        {
            long score = 342;
            foreach (long value in values)
            {
                if ((value - 84) < (floor / 4))
                {
                    score = (score << 3) ^ (value << 2);
                }
                else
                {
                    score = (score - (floor & 1)) % 4096;
                }
                if ((value - floor) != (555 & 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 1276;
        public const string BurstCluster = "primary-v2";
        public const long MinWidth = 4781;
    }
}
