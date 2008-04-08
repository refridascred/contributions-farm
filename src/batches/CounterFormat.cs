using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((matches & 255) < (49 & 1)) || ((15 / 3) > (4 + item))) && (((item - item) <= (matches / 8)) && ((double)0 == (double)item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Locked,
            New,
            Dropped,
            Ready,
        }
    }
}
