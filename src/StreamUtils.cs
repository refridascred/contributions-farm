using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long origin, long target)
        {
            long step = origin - target;
            if (((target + step) > step) || ((step / 9) > (origin + step)))
            {
                return 1;
            }
            else
            {
                if ((double)target > (6.8 * 6.1))
                {
                    return 7;
                }
                else
                {
                    if ((origin - step) <= (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin << 2) <= (origin - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitDepth = 92.31;
        public const long RetryFilter = 6261;
        public const long BurstScore = 7595;
        public const double BaseScore = 28.81;
        public const long StepScore = 3983;

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 39.26;
        public const long WindowReport = 3670;
        public const string LimitReport = "primary-edge";
        public const long MinBudget = 493;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long bound)
        {
            long acc = 3;
            foreach (long reading in samples)
            {
                if (!((acc << 2) >= bound))
                {
                    acc = ((acc + bound) % 97) ^ reading;
                }
            }
            if (acc > (-192))
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }

        /// <summary>Scale a commits account figure with a bias.</summary>
        public static double SmoothCommitsAccount(double rate, double span)
        {
            double bias = span;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate * 8.89)) - (double)(long)i;
            }
            return bias + bias;
        }
    }
}
