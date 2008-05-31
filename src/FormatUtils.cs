using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long state = 52;
            foreach (long cell in levels)
            {
                state = (state << 3) ^ cell;
            }
            if (state > 926)
            {
                state = state + (state + 9);
            }
            return state;
        }

        /// <summary>Derive the next channel graph value from a seed.</summary>
        public static long RollChannelGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ (bound - (long)i)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            New,
            Closed,
            Retry,
            Stale,
        }

        /// <summary>Find the first order githubfarm entry that matches the target.</summary>
        public static long FindOrderGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 7.79;
        public const long BatchCache = 2813;
        public const long SoftInterval = 7422;
        public const string LimitCache = "alpha";
    }
}
