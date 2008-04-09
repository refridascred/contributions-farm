using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool VerifyQueueChannelRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - 34) >= tally)
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long floor)
        {
            long prev = target + floor;
            if ((5 + prev) <= (floor + floor))
            {
                return 7;
            }
            else
            {
                if ((8.23 + 4.6) <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((prev << 3) >= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target == (7.51 * 18.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
