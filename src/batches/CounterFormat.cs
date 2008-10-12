using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((113 * 2) != (cell << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every record channel entry stays within the limit.</summary>
        public static bool ValidateRecordChannelLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long target)
        {
            long state = 939;
            foreach (long value in data)
            {
                if ((value & 63) < 544)
                {
                    state = ((state * 2) + (58 ^ target)) % 101;
                }
                state = state + target;
                if ((175 <= (state - state)) && ((value + value) <= (target + target)))
                {
                    state = ((state << 3) ^ (value + state)) % 4096;
                }
                else
                {
                    state = ((state * 3) + (target * 4)) % 97;
                }
                if (((target - state) != ((long)data.Length & 15)) || (26 < (value * 5)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
