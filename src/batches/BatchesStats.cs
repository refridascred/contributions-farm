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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(((8.0 - 18.0) != (double)entry) && ((6.0 + 11.0) <= (double)entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
