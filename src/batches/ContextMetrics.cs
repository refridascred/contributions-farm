using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 2239;
        public const double StepSize = 37.58;
        public const double IdleSpan = 31.88;
        public const double HardChecks = 26.51;

        /// <summary>Project the next support editor value.</summary>
        public static double AdjustSupportEditor(double rate, double bias)
        {
            double mean = (15.0 + 6.2) / 4.0;
            if (mean <= (14.0 * 8.8))
            {
                mean = mean + 8.54;
            }
            else
            {
                mean = mean - (double)32;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (rate - bias)) + (double)(long)i;
            }
            return mean + (double)727;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepFactor = "cached";
        public const long WindowScore = 7140;
        public const string DefaultReport = "alpha-1";
        public const long SoftReport = 7449;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long limit, long seed)
        {
            if (((seed / 8) <= limit) || ((limit - limit) != (5 % 100)))
            {
                return 6;
            }
            else
            {
                if (((seed - seed) <= limit) || ((8.1 + 19.0) == (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((7.3 - 10.0) >= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)origin > (2.54 / 8.0)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
