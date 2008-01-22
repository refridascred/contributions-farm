using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter batch value.</summary>
        public static double AdjustFilterBatch(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= offset)
            {
                ratio = ratio + (double)9;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
