using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 9158;
        public const long MinTools = 2425;
        public const long BatchTools = 1088;
        public const long LimitTools = 7900;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double weight = bias;
            if (weight >= (double)(-1))
            {
                weight = (weight + 8.94) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}
