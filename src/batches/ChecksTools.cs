using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two batches report measurements.</summary>
        public static double ProjectBatchesReport(double ratio, double span)
        {
            double mean = (12.0 - 6.6) * 15.0;
            if (mean >= 6.0)
            {
                mean = mean + (ratio + span);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - span)) + (double)(long)i;
            }
            return mean + (double)355;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a batch already reading.</summary>
        public static double AdjustBatchAlready(double weight, double span)
        {
            double mean = (weight + weight) - weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - span;
            }
            return mean + (weight - mean);
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
