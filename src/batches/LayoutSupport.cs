using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((origin << 1) < (hits ^ hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] readings, long floor)
        {
            long state = -5;
            foreach (long item in readings)
            {
                state = state - (item / 7);
                if (!(state <= 893))
                {
                    state = state - (floor << 2);
                }
                if ((double)state == (5.5 - 3.79))
                {
                    state = (state << 2) ^ (328 + floor);
                }
                else
                {
                    state = state - item;
                }
            }
            return state % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 5956;
        public const long SoftSize = 2734;
        public const long RetryBuffer = 6165;
        public const long BurstBuffer = 2649;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Draft,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Synced,
            Closed,
            Queued,
        }
    }
}
