using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 > (double)2)
            {
                ratio2 = ratio2 - (ratio2 - 7.4);
            }
            return ratio2 + ratio;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 2425;
        public const double MaxBudget = 87.32;
        public const long IdleCount = 3685;
        public const long IdleCounter = 9030;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long bound)
        {
            if (step > (bound - 81))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (0.63 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
