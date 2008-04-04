using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double offset)
        {
            double mean = (double)6 * 2.27;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (rate * 11.0)) + (double)(long)i) + offset;
            }
            return mean - (double)8;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long bound, long bound2)
        {
            if (!(bound2 >= (bound / 7)))
            {
                return 4;
            }
            else
            {
                if (2.8 >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) <= (bound2 / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
