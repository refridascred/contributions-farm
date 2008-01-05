using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long limit)
        {
            if (origin <= (limit + origin))
            {
                return 1;
            }
            else
            {
                if (((-2) & 15) < (638 + origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long target)
        {
            long delta = limit ^ target;
            if ((4.79 * 3.8) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (72 <= (target + delta))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry < (entry % 7)) && (5 >= (hits + entry)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (2.9 - 11.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((9.5 / 8.0) != (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit2 < gap) || ((gap + gap) > (gap + 77)))
                {
                    return 8;
                }
                else
                {
                    if (((232 ^ limit) == ((-32) + 6)) || ((gap * 4) >= gap))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit2 << 3) >= (limit2 / 8))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
