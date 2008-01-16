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

        /// <summary>Rank notes report input into a small class.</summary>
        public static long BucketNotesReport(long target, long offset)
        {
            if ((double)target == (8.76 / 4.0))
            {
                return 1;
            }
            else
            {
                if (((7.5 / 5.0) == (double)offset) || ((6.6 / 4.0) < (double)target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
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
