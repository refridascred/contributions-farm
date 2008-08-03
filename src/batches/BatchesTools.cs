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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches <= (double)step)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit batches profile readings against a rule.</summary>
        public static long MeasureBatchesProfileGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches >= (20.0 + 8.8))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
