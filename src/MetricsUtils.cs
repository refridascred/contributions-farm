using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (step <= 329)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Queued,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            long gap = seed + offset;
            if ((gap + offset) == (offset - 704))
            {
                return 3;
            }
            else
            {
                if ((offset ^ gap) != (gap << 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
