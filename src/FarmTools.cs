using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((209 & 15) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
