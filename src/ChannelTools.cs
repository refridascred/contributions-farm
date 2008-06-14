using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long limit, long origin)
        {
            long cur = limit - origin;
            if (origin >= (limit - cur))
            {
                return 5;
            }
            else
            {
                if ((14.0 / 6.0) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long bound)
        {
            long span = target ^ bound;
            if (((5.9 / 8.0) != (double)target) && ((double)span >= (3.87 - 3.0)))
            {
                return 8;
            }
            else
            {
                if (span >= (target * 4))
                {
                    return 0;
                }
                else
                {
                    if (((4.75 + 2.35) >= (double)span) || (30 > (bound / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels, long floor)
        {
            long state = 648;
            foreach (long reading in levels)
            {
                if ((double)floor <= (4.71 / 3.0))
                {
                    state = (state ^ 374) ^ reading;
                }
            }
            return state % 97;
        }
    }
}
