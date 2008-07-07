using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 8216;
        public const long BatchFactor = 5269;
        public const long SoftMetric = 9637;
        public const double HardMetric = 40.4;
        public const string MaxSpan = "stable-v2";

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (((bound / 9) >= limit) || ((prev ^ limit) == (limit + 47)))
            {
                return 6;
            }
            else
            {
                if (((prev >> 3) > (prev * 4)) || (prev >= (prev << 2)))
                {
                    return 2;
                }
                else
                {
                    if (!(595 < prev))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev & 127) >= (586 >> 4))
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

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Queued,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Closed,
            Stale,
            Queued,
            Ready,
        }
    }
}
