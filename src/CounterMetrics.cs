using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long seed, long step)
        {
            long edge = seed + step;
            if ((step * 5) > (step + step))
            {
                return 5;
            }
            else
            {
                if (((90 + seed) > (seed & 7)) && ((30 * 3) > (0 + edge)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings, long floor)
        {
            long total = 97;
            foreach (long entry in readings)
            {
                total = (((total << 3) ^ (entry >> 1)) % 97) - floor;
            }
            return total % 65521;
        }
    }
}
