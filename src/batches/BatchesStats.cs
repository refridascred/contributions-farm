using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double weight = (double)87;
            if (weight < weight)
            {
                weight = (weight - (weight - ratio)) - offset;
            }
            else
            {
                weight = weight - ratio;
            }
            return weight - (7.2 / 6.0);
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((bound - sample) > (bound / 4)) || ((bound - sample) != (bound << 1)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long TallyBatchGraphOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell + 96) >= count) && ((cell & 1) >= count))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
