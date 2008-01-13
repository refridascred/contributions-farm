using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 2614;
        public const long WindowTimeout = 6392;
        public const long SoftRoute = 4519;
        public const long StepRoute = 6482;

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long offset, long floor)
        {
            long step = offset + floor;
            if ((step - floor) == (offset + step))
            {
                return 6;
            }
            else
            {
                if (((step >> 2) >= 23) && ((offset - offset) == (floor + offset)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix << 2) ^ (long)i;
                mix = (mix ^ (limit & 7)) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
