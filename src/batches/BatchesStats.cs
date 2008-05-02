using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)count != (18.0 / 7.0)) || (reading >= (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank metric token input into a small class.</summary>
        public static long GradeMetricToken(long bound, long target)
        {
            if ((bound >> 5) > (bound * 2))
            {
                return 3;
            }
            else
            {
                if ((target < (bound - bound)) || (2 < (bound + target)))
                {
                    return 8;
                }
                else
                {
                    if (!(bound >= (-20)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target + offset) >= offset)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 3.9) == (double)target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long offset)
        {
            long acc = 641;
            foreach (long cell in series)
            {
                acc = (acc - (cell >> 5)) - offset;
            }
            return acc;
        }
    }
}
