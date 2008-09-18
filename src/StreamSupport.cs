using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format cluster entries that pass the check.</summary>
        public static long TallyFormatClusterOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)target >= 1.97)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double drift = weight;
            if (drift > (offset - 17.0))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift + (double)33;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset + weight)) + (double)(long)i;
            }
            return drift - (drift * 7.8);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
        }
    }
}
