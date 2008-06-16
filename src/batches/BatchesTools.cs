using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "fallback";
        public const double SoftChannel = 65.99;
        public const long HardCount = 43;
        public const long LimitFactor = 1459;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long bound, long step)
        {
            if ((double)step != (1.0 + 5.6))
            {
                return 6;
            }
            else
            {
                if ((step + bound) < step)
                {
                    return 5;
                }
                else
                {
                    if ((7.1 + 9.2) <= (5.41 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((58 - bound) >= (step + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double drift = (gain - floor) - (gain + floor);
            if (drift < (double)69)
            {
                drift = drift - (gain + drift);
            }
            else
            {
                drift = drift - floor;
            }
            return drift + (double)3;
        }
    }
}
