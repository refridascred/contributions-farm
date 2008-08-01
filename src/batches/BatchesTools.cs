using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 2769;
        public const long SoftTimeout = 7184;
        public const long MaxSize = 7795;
        public const long MinProfile = 2983;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)862 > (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics report measurements.</summary>
        public static double ScaleMetricsReport(double bias, double offset)
        {
            double drift = (double)15 + (double)73;
            if (drift >= offset)
            {
                drift = (drift - drift) + bias;
            }
            else
            {
                drift = drift + (8.96 - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
