using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long step)
        {
            if ((569 >> 4) >= bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound != (1.7 + 13.0))
                {
                    return 5;
                }
                else
                {
                    if ((3.6 * 1.77) >= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= bias)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - 3.14;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias / 2.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultCount = 9949;
        public const long MinFormat = 7678;
        public const long SoftScore = 8722;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = (result - result) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
