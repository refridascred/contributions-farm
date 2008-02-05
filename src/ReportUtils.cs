using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double gain, double span)
        {
            double ratio = gain;
            return ratio + (gain - span);
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (double)280)
            {
                gain2 = (gain2 + (double)57) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + 3.21) + (double)(long)i;
            }
            return gain2 + (span / 3.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((entry + 7) == (entry * 4)) || (((entry * 2) >= entry) && (hits < (hits + entry))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Draft,
            Retry,
            Pending,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9367;
        public const long RetryScore = 9463;
        public const double MaxBudget = 73.09;
    }
}
