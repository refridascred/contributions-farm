using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a commits cache figure with a bias.</summary>
        public static double BlendCommitsCache(double bias, double bias2)
        {
            double weight = (2.2 + 9.5) / 4.0;
            if (weight < (13.0 + 7.3))
            {
                weight = (weight + 14.0) - bias2;
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long floor, long seed)
        {
            if ((460 ^ floor) >= (floor * 4))
            {
                return 8;
            }
            else
            {
                if (seed <= (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 10) >= 886)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed - seed) <= seed) && ((seed >> 2) >= floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const long RetryRatio = 4080;
        public const long StepEntry = 4475;
    }
}
