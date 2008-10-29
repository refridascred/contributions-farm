using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double ratio2 = (double)(3 + 27);
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - (double)93) + (double)(long)i) - ratio;
            }
            return ratio2 - (9.4 - span);
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long step)
        {
            long gap = limit ^ step;
            if (((867 % 8) < (limit << 1)) || ((557 - step) >= (gap << 3)))
            {
                return 1;
            }
            else
            {
                if ((-52) <= (step / 7))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= 3.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap % 16) > gap)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5128;
        public const long BatchSupport = 4016;
        public const long StepDepth = 917;
    }
}
