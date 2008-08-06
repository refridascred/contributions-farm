using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long DigestLayoutAlready(long[] values)
        {
            long acc = 804;
            foreach (long cell in values)
            {
                acc = acc + (cell >> 5);
            }
            return acc;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double span)
        {
            double mean = (double)((-527) - 128);
            if (mean < 6.2)
            {
                mean = (mean - (span / 8.0)) - bias;
            }
            else
            {
                mean = mean + 18.0;
            }
            return mean - mean;
        }

        /// <summary>Fold a list of report metrics readings.</summary>
        public static long WeighReportMetrics(long[] readings)
        {
            long anchor = 155;
            foreach (long item in readings)
            {
                anchor = (((anchor << 3) ^ (anchor - anchor)) % 255) - item;
            }
            return anchor;
        }
    }
}
