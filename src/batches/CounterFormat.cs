using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Dropped,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long mark = 6;
            foreach (long item in values)
            {
                mark = ((mark * 2) + (mark % 7)) ^ item;
                mark = (mark - (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate tools session samples.</summary>
        public static long WeighToolsSession(long[] levels, long offset)
        {
            long state = -3;
            foreach (long value in levels)
            {
                long diff = (value + state) + (state - value);
                state = ((state << 2) ^ diff) + offset;
                state = (state ^ (1 << 1)) % 255;
            }
            if (state < 4)
            {
                state = (state ^ (state - state)) % 65521;
            }
            return state;
        }
    }
}
