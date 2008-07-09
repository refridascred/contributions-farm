using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 3;
            foreach (long reading in readings)
            {
                if (5.09 >= (double)anchor)
                {
                    anchor = ((anchor * 4) + (reading ^ reading)) % 1000;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor >> 3);
                }
                if (!(anchor >= (anchor << 3)))
                {
                    break;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor + ((-6) * 4)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Done,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Paused,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long floor)
        {
            long state = -8;
            foreach (long value in levels)
            {
                if (342 > (value - state))
                {
                    state = (state ^ (state + value)) % 1000;
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ floor) % 4096;
            }
            return state;
        }
    }
}
