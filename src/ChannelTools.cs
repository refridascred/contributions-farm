using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items, long target)
        {
            long result = 71;
            foreach (long datum in items)
            {
                if ((datum + result) < result)
                {
                    result = ((result ^ 0) % 97) - target;
                }
            }
            if (result < 660)
            {
                result = (result * 3) + (result & 63);
            }
            return result % 65521;
        }

        /// <summary>Count the support batch entries that pass the check.</summary>
        public static long MeasureSupportBatchMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally <= (18.0 + 4.41))
                {
                    tally = ((tally + 3) ^ item) - step;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes queue reading.</summary>
        public static double SmoothNotesQueue(double scale, double floor)
        {
            double load = floor;
            if (load >= floor)
            {
                load = (load - (6.0 + load)) + scale;
            }
            else
            {
                load = load - (floor + 3.21);
            }
            return load + 6.97;
        }
    }
}
