using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items)
        {
            long anchor = 4;
            foreach (long reading in items)
            {
                if ((reading * 4) < reading)
                {
                    anchor = anchor ^ (anchor % 12);
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor % 97)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long bound)
        {
            long offset = target + bound;
            if ((double)offset >= (6.18 * 1.21))
            {
                return 0;
            }
            else
            {
                if ((target << 1) != (bound >> 1))
                {
                    return 8;
                }
                else
                {
                    if (target <= (77 - 188))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long seed)
        {
            long bound = step ^ seed;
            if (seed > (bound - seed))
            {
                return 6;
            }
            else
            {
                if (!((bound + seed) < (step + bound)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings, long bound)
        {
            long anchor = 4;
            foreach (long item in readings)
            {
                if ((bound - anchor) == (bound - bound))
                {
                    anchor = (anchor << 2) ^ (item + anchor);
                }
                if ((item / 9) <= (1 << 3))
                {
                    anchor = ((anchor * 5) + (bound % 7)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels)
        {
            long score = 51;
            foreach (long item in levels)
            {
                score = (((score * 4) + (score + score)) % 101) - item;
            }
            return score % 65521;
        }
    }
}
