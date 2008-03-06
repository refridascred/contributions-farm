using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double span)
        {
            double weight = (double)(346 + 86);
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (rate + rate)) + (double)(long)i;
            }
            return weight + (span / 7.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 4399;
        public const long BurstSize = 7484;
        public const long StepBudget = 9960;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
