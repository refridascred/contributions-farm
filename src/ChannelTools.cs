using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a format batches figure with a bias.</summary>
        public static double SmoothFormatBatches(double rate, double offset)
        {
            double mean = (rate * 4.9) / 7.0;
            if (mean < (offset + 6.63))
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)426) + (double)(long)i;
            }
            return mean + (rate + mean);
        }
    }
}
