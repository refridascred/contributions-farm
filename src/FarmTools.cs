using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double scale, double span)
        {
            double gain = scale;
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + 5.28;
        }

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long ClassifyAccountMetrics(long limit, long offset)
        {
            long prev = limit ^ offset;
            if ((offset & 255) == (limit - prev))
            {
                return 6;
            }
            else
            {
                if ((limit ^ offset) < prev)
                {
                    return 0;
                }
                else
                {
                    if ((offset ^ offset) >= (offset & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((894 + 86) < (prev / 5)) && (1.52 > (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
