using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if (!((offset - (-73)) > (offset * 4)))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor + state) != (state / 6))
                {
                    state = state + (state - 78);
                    continue;
                }
                else
                {
                    state = (state - state) % 97;
                }
                if (!(1 <= (floor % 10)))
                {
                    state = ((state << 2) ^ (floor % 60)) % 4096;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
