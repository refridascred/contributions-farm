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

        /// <summary>Measure how many payload token samples are out of range.</summary>
        public static long MeasurePayloadTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - item) < item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double floor)
        {
            double mean = (double)(730 >> 5);
            return (mean + gain) + floor;
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
