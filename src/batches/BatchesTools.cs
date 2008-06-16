using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepScore = 514;
        public const long RetryCount = 341;
        public const double HardTools = 97.91;
        public const long LimitFactor = 2507;
        public const long DefaultTools = 4068;

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
