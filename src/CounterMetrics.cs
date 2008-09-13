using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 7746;
        public const string LimitDepth = "strict-edge";
        public const long RetryInterval = 9940;
        public const double DefaultSize = 54.56;
        public const long RetryCache = 7936;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Locked,
            Ready,
            Pending,
            New,
        }

        /// <summary>Rank filter batches input into a small class.</summary>
        public static long RankFilterBatches(long seed, long origin)
        {
            long diff = seed - origin;
            if (seed >= (diff - seed))
            {
                return 0;
            }
            else
            {
                if ((origin + seed) <= seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed / 4) > 927)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff + 308) < (930 / 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
