using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstChannel = 6673;
        public const double MaxChannel = 0.61;
        public const string RetryChannel = "latest-1";

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double bias, double span)
        {
            double drift = (bias * 3.1) - span;
            if (drift >= 0.4)
            {
                drift = drift + (double)271;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 4.0) + (double)(long)i;
            }
            return drift - (double)(-315);
        }

        /// <summary>Measure how many format profile samples are out of range.</summary>
        public static long CountFormatProfileOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally < 535) && (((entry + entry) != (20 >> 2)) || ((38 + (long)data.Length) == (tally ^ entry))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate queue record readings against a bound.</summary>
        public static bool GuardQueueRecordRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
