using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long SeriesAccountCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a token metrics sample.</summary>
        public static long LocateTokenMetricsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long limit)
        {
            long bound = step ^ limit;
            if ((bound <= 63) || ((double)step < (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound * 5) <= limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (6.0 / 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((0.9 * 7.0) != (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((origin << 2) < (500 + sample)) || (origin < (hits + origin)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
