using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double ratio = (double)302 - (gain * 9.46);
            if (ratio >= (double)208)
            {
                ratio = ratio - (gain + 4.86);
            }
            return ratio + (span + span);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches >= (1.48 + 15.0))
                {
                    matches = ((matches + 1) + entry) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
