using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((limit >> 2) >= (850 + (-236)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Queued,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long limit)
        {
            long acc = 48;
            foreach (long sample in values)
            {
                if ((6.0 * 7.5) != (double)limit)
                {
                    acc = ((acc ^ (-758)) % 1000) ^ sample;
                }
            }
            if (acc > 0)
            {
                acc = acc - (limit * 2);
            }
            return acc;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long offset, long target)
        {
            if ((target >= (offset >> 1)) || (target < (target >> 2)))
            {
                return 3;
            }
            else
            {
                if ((target - offset) >= (target << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
