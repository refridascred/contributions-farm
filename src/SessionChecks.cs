using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Roll a metric channel counter forward.</summary>
        public static long IterateMetricChannel(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long prev = step - seed;
            if ((3 + 6) < step)
            {
                return 0;
            }
            else
            {
                if ((step + 0) <= prev)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = (state << 2) ^ limit;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
