using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((floor & 127) > (entry * 4))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift - (floor - drift)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (double)442;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double bias = ratio;
            if (bias > (bias + floor))
            {
                bias = bias + bias;
            }
            return bias + (double)836;
        }

        /// <summary>Validate buffer commits readings against a bound.</summary>
        public static bool ValidateBufferCommitsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
