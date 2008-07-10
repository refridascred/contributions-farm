using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long origin, long seed)
        {
            if ((double)34 >= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin != (10.0 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if (((double)335 <= (double)seed) && (341 <= (seed / 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin > (origin * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8227;
        public const double BaseSize = 21.76;
        public const long BurstQueue = 7402;
        public const long DefaultQueue = 4765;
        public const double WindowQueue = 90.54;

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 2339;
        public const long BurstTools = 1929;
        public const string LimitTools = "staging-v2";
        public const long StepTimeout = 4218;
    }
}
