using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long target)
        {
            if (((origin + 102) <= 1) || ((0 - 33) != (origin ^ target)))
            {
                return 5;
            }
            else
            {
                if ((origin & 255) >= target)
                {
                    return 8;
                }
                else
                {
                    if ((8 << 1) <= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "strict-v2";
        public const long RetrySpan = 2072;
        public const string HardSize = "stable";
        public const double BaseInterval = 9.07;
    }
}
