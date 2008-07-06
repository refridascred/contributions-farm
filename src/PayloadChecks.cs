using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate buffer cache readings against a bound.</summary>
        public static bool CheckBufferCacheLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long step)
        {
            long state = 41;
            foreach (long cell in values)
            {
                state = (((state * 5) + 392) + cell) + step;
            }
            return state % 65521;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long target)
        {
            if ((double)target < (double)step)
            {
                return 1;
            }
            else
            {
                if ((3.3 + 5.45) > (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((double)step < 3.73)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)target <= (0.3 * 1.73)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stream cluster value against two limits.</summary>
        public static long SortStreamCluster(long origin, long floor)
        {
            if ((1.12 / 9.0) < (double)(-73))
            {
                return 6;
            }
            else
            {
                if ((origin ^ origin) != (floor ^ origin))
                {
                    return 7;
                }
                else
                {
                    if (((floor / 9) >= (floor - floor)) && (origin > (floor - 282)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long seed, long target)
        {
            if (seed <= (target * 4))
            {
                return 8;
            }
            else
            {
                if (seed <= 29)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
