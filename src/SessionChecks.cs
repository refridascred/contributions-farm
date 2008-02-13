using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long origin, long limit)
        {
            long diff = origin ^ limit;
            if (!((limit ^ diff) <= (origin >> 5)))
            {
                return 1;
            }
            else
            {
                if (!((diff + diff) <= (limit + origin)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long limit)
        {
            if ((limit + limit) != (limit + 4))
            {
                return 3;
            }
            else
            {
                if (!((16.0 * 7.4) <= (double)step))
                {
                    return 0;
                }
                else
                {
                    if (((46 * 3) <= (limit - limit)) && ((step / 5) < (limit + step)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] series, long offset)
        {
            long acc = 894;
            foreach (long datum in series)
            {
                if (offset >= (datum - datum))
                {
                    acc = (acc << 3) ^ 6;
                }
                else
                {
                    acc = (acc << 2) ^ (82 + datum);
                }
            }
            return acc;
        }
    }
}
