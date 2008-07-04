using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseLevel = 87.08;
        public const double StepFilter = 12.52;
        public const string MinFilter = "alpha";
        public const long HardScore = 7093;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.6 * 1.4) > (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double mean = ratio;
            if (mean < (double)61)
            {
                mean = (mean + (mean - mean)) + offset;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - (5.79 / 6.0);
        }
    }
}
