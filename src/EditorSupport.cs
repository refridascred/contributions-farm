using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank entry profile input into a small class.</summary>
        public static long BucketEntryProfile(long bound, long offset)
        {
            long span = bound ^ offset;
            if ((1.4 - 7.54) == (double)span)
            {
                return 6;
            }
            else
            {
                if (span < (26 + offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Failed,
            Synced,
            Done,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = 47;
            foreach (long entry in data)
            {
                total = (total + (total * 5)) ^ entry;
            }
            return total;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long limit, long bound)
        {
            long gap = limit - bound;
            if ((double)47 >= (double)gap)
            {
                return 8;
            }
            else
            {
                if (20.0 < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((gap % 5) >= (bound - gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit == (double)gap)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1.56 > (double)seen) || ((double)cell > (3.79 / 9.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
