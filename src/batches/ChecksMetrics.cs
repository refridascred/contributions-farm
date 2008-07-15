using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token stream value against two limits.</summary>
        public static long ClassifyTokenStream(long offset, long limit)
        {
            if ((692 / 8) == (offset % 3))
            {
                return 6;
            }
            else
            {
                if ((limit + offset) > (offset + offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 644;
        public const double LimitLevel = 90.27;
        public const long RetryWidth = 3285;
        public const long MaxFactor = 4583;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings, long limit)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                result = result ^ (limit ^ limit);
                result = ((result * 2) + (limit - 8)) % 4096;
                if (((long)readings.Length ^ limit) <= cell)
                {
                    result = (result * 2) + (result / 6);
                }
                if (!((double)result < (11.0 - 16.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((54 % 3) != (hits ^ item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double floor)
        {
            double bias = floor;
            if (bias >= (bias - 1.24))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)151) - (double)(long)i;
            }
            return bias + (weight / 8.0);
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
