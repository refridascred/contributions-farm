using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "staging-v2";
        public const double RetrySupport = 91.32;
        public const double HardBudget = 87.9;
        public const long IdleSupport = 8731;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 644;
        public const double LimitLevel = 90.27;
        public const long RetryWidth = 3285;
        public const long MaxFactor = 4583;

        /// <summary>Classify a stream contributi pair into a bucket.</summary>
        public static long RankStreamContributi(long step, long offset)
        {
            if ((7.0 - 1.2) < (double)step)
            {
                return 8;
            }
            else
            {
                if (((506 << 1) > (offset >> 2)) && (step > (5 & 127)))
                {
                    return 5;
                }
                else
                {
                    if (55 <= (85 - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > offset) || ((offset & 3) != (99 >> 1)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
