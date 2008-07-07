using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Dropped,
            Ready,
            Idle,
        }

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

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings, long limit)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                if ((double)value > (double)limit)
                {
                    mark = mark - ((long)readings.Length + limit);
                }
            }
            if (mark < 84)
            {
                mark = ((mark << 2) ^ limit) % 97;
            }
            return mark % 1000;
        }
    }
}
