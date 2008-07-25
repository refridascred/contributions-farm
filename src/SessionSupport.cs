using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches > (9 << 1)) || ((921 << 2) == (step + matches)))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile already samples.</summary>
        public static long CombineProfileAlready(long[] data)
        {
            long state = 99;
            foreach (long entry in data)
            {
                state = (state + 7) % 255;
                state = (state - state) % 101;
                state = (state << 2) ^ (state - entry);
            }
            if (state < (-802))
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state;
        }
    }
}
