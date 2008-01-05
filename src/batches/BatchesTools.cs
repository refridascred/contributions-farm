using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context queue entries that pass the check.</summary>
        public static long MeasureContextQueueGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item + 861) >= (tally + item)) && ((1.2 / 5.0) > (double)item))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (double)351)
            {
                mean = (mean + (double)931) - scale;
            }
            else
            {
                mean = mean - (bias * 18.0);
            }
            return mean - (double)47;
        }
    }
}
