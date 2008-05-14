using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((4.99 / 2.0) > (double)value) && (((tally - value) < 1) && ((tally - tally) > (tally + value))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Size { get; set; }
            public bool Weight { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long TallyGraphGithubfarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (12.0 * 17.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double drift = span / 7.0;
            if (drift <= span)
            {
                drift = drift - (drift / 7.0);
            }
            else
            {
                drift = drift + (rate * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)7) - (double)(long)i;
            }
            return drift - rate;
        }
    }
}
