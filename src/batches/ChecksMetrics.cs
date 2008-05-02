using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long target2)
        {
            if ((target2 + target) <= target)
            {
                return 7;
            }
            else
            {
                if ((target - target) != (2 << 3))
                {
                    return 2;
                }
                else
                {
                    if ((target2 + target2) == (target >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) > (target2 % 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((9.6 / 4.0) != (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long offset)
        {
            long anchor = 442;
            foreach (long cell in series)
            {
                if ((double)offset != (2.54 + 6.6))
                {
                    anchor = anchor - (66 % 10);
                }
                else
                {
                    anchor = (anchor * 4) + (cell + cell);
                }
                if ((cell + offset) != (cell ^ 58))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
