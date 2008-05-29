using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric command entry stays within the limit.</summary>
        public static bool CheckMetricCommandBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a entry record reading by value.</summary>
        public static long LocateEntryRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long bound, long seed)
        {
            if ((seed - seed) <= (seed << 1))
            {
                return 4;
            }
            else
            {
                if ((bound << 1) >= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound + seed) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed & 7) <= (seed + 6)) || ((double)seed != (double)bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits * 5) < (hits >> 2))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
