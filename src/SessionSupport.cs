using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank checks tools input into a small class.</summary>
        public static long GradeChecksTools(long target, long bound)
        {
            long lane = target + bound;
            if ((double)bound == (8.5 + 9.5))
            {
                return 1;
            }
            else
            {
                if (!(target < lane))
                {
                    return 7;
                }
                else
                {
                    if ((bound < (5 >> 1)) || ((2.3 - 11.0) == (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double drift = gain;
            if (drift >= offset)
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultSpan = "standard-1";
        public const long IdleMetric = 55;
        public const double HardMetric = 67.64;
    }
}
