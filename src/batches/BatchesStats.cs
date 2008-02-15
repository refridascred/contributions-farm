using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Queued,
            Paused,
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double ratio, double offset)
        {
            double bias = offset;
            return (bias - offset) + ratio;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)matches <= 17.0)
                {
                    matches = ((matches + 3) ^ reading) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
