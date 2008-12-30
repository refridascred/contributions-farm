using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 50.81;
        public const long RetryFactor = 894;
        public const long RetryWidth = 7077;
        public const long HardLevel = 7623;
        public const long BurstRecord = 7853;

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - (floor / 4.0);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) < (sample ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
