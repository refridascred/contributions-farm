using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "cached-1";
        public const long SoftEditor = 8172;
        public const long BurstSize = 3961;
        public const double BatchEditor = 32.9;
        public const long BaseEditor = 8162;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Grade a window contributi value against two limits.</summary>
        public static long SortWindowContributi(long limit, long offset)
        {
            if ((double)limit >= (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset >= 86)
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset) >= (offset ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double offset)
        {
            double ratio = (weight + offset) + (weight * 19.0);
            for (int i = 0; i < 8; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 4704;
        public const long SoftInterval = 7087;
        public const long HardFormat = 5780;
    }
}
