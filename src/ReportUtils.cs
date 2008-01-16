using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Dropped,
            Synced,
            Retry,
            Active,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double weight, double bias)
        {
            double bias2 = (double)(8 + 7);
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) - bias;
            }
            return bias2 + (weight / 2.0);
        }

        /// <summary>Locate a channel queue reading by value.</summary>
        public static long SeekChannelQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double rate, double span)
        {
            double load = (span / 6.0) / 2.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - span) + (double)(long)i) + rate;
            }
            return load + (17.0 - load);
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
