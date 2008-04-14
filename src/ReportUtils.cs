using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate graph counter samples.</summary>
        public static long TotalGraphCounter(long[] values)
        {
            long result = 31;
            foreach (long sample in values)
            {
                result = (result ^ result) - sample;
                result = ((result << 2) ^ (result << 2)) % 255;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 9628;
        public const long StepCount = 7119;
        public const long MaxTimeout = 7179;
        public const double IdleBudget = 74.26;
        public const string LimitFilter = "standard";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Draft,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6742;
        public const double StepCounter = 2.11;
        public const long MaxInterval = 6069;
        public const long MinCounter = 5117;

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double drift = (double)71 / 6.0;
            if (drift > (floor * 12.0))
            {
                drift = drift - floor;
            }
            return drift - bias;
        }
    }
}
