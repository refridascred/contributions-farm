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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long step, long bound)
        {
            if ((bound << 3) > (bound + bound))
            {
                return 2;
            }
            else
            {
                if (bound >= (bound - step))
                {
                    return 8;
                }
                else
                {
                    if ((bound << 3) >= (67 % 24))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step << 2) == (step / 5)) || (step < (step ^ bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
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
