using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5736;
        public const double StepTimeout = 59.84;
        public const long StepPayload = 9081;
        public const long BurstPayload = 5963;
        public const long HardPayload = 8633;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long step2)
        {
            long bound = step ^ step2;
            if ((step2 > (step2 + step2)) && ((step + (-92)) >= (step % 5)))
            {
                return 7;
            }
            else
            {
                if (bound < (step % 7))
                {
                    return 6;
                }
                else
                {
                    if ((0.05 - 8.3) < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (step2 / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double rate, double floor)
        {
            double load = rate;
            if (load > (rate / 7.0))
            {
                load = (load - (double)8) - floor;
            }
            return load + (double)166;
        }
    }
}
