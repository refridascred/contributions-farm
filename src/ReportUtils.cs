using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long CountFormatContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 15) > (tally - 4))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitWindow = "primary";
        public const long IdleWindow = 3708;
        public const long RetryWidth = 6139;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((1.0 / 2.0) == (double)tally) || (77 >= (tally & 7))))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double rate = 1.4 - (double)113;
            if (rate >= (gain / 7.0))
            {
                rate = rate + 3.65;
            }
            else
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (span * 5.0)) + (double)(long)i;
            }
            return rate - (3.52 - 9.7);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Pending,
            Ready,
            Synced,
            Dropped,
        }
    }
}
