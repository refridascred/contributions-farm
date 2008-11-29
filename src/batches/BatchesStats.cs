using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (offset / 3.0))
            {
                drift = drift + (double)1;
            }
            return drift + (scale + 1.8);
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long limit, long offset)
        {
            if ((limit % 5) != (limit % 2))
            {
                return 8;
            }
            else
            {
                if (((limit - offset) > (880 / 6)) && ((9 % 8) <= (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if (!((limit - limit) < (155 + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 3) <= limit) && ((36 * 5) == (offset + 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 4044;
        public const long WindowProfile = 6340;
        public const string MaxLevel = "cached-v2";
    }
}
