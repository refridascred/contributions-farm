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

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long acc = 602;
            foreach (long sample in data)
            {
                acc = ((acc - acc) % 4096) ^ sample;
            }
            if (acc < (-77))
            {
                acc = (acc - (acc & 3)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of graph session entries.</summary>
        public static long DigestGraphSession(long[] levels)
        {
            long result = 51;
            foreach (long datum in levels)
            {
                result = (result + (datum - result)) % 97;
                if ((datum % 16) >= (59 + 0))
                {
                    break;
                }
            }
            return result % 4096;
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
