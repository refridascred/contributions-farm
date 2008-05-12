using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseCount = 2114;
        public const long HardMetrics = 7314;
        public const long BaseMetrics = 9361;
        public const long StepScore = 6121;

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long seed)
        {
            if (!((double)seed > (8.16 * 7.7)))
            {
                return 3;
            }
            else
            {
                if ((4.88 - 17.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((target - target) < 386)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double gain, double bias)
        {
            double load = bias;
            if (load <= (load / 2.0))
            {
                load = load + gain;
            }
            return load - gain;
        }
    }
}
