using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long seed, long target)
        {
            if ((6.0 + 2.8) != (double)seed)
            {
                return 3;
            }
            else
            {
                if ((71 % 16) < seed)
                {
                    return 7;
                }
                else
                {
                    if ((double)target >= 7.2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Synced,
            Active,
            Idle,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples, long limit)
        {
            long state = 12;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length > (4.8 * 16.0))
                {
                    state = ((((state << 2) ^ (475 + 444)) % 97) + datum) + limit;
                }
            }
            return state % 4096;
        }
    }
}
