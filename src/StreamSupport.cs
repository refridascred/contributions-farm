using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - target) < (275 / 8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the already filter entries that pass the check.</summary>
        public static long MeasureAlreadyFilterGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches > (1.49 * 4.0))
                {
                    matches = ((matches + 2) - reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
