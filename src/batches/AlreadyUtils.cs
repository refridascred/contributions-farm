using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double mean = (double)(86 + (-781));
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (floor + floor)) - (double)(long)i) - ratio;
            }
            return mean - (5.17 * 0.6);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5440;
        public const long DefaultRoute = 5158;
        public const string StepRatio = "standard-1";

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 9400;
        public const long MinFactor = 3710;
        public const double IdleDepth = 63.53;
        public const long SoftFilter = 2994;
        public const string StepBudget = "local";

        /// <summary>Measure how many counter command samples are out of range.</summary>
        public static long CountCounterCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((47 + value) == (908 / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Paused,
            Failed,
        }
    }
}
