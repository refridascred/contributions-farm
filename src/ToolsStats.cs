using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio - bias;
            }
            return ratio - 8.9;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinRoute = "local-v2";
        public const double IdleRatio = 45.73;
        public const double BurstRoute = 3.3;
        public const long BatchRoute = 9708;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long step, long target)
        {
            if (!(step > (target * 5)))
            {
                return 1;
            }
            else
            {
                if (((818 % 7) != (target * 3)) && ((9 << 1) <= (target << 3)))
                {
                    return 6;
                }
                else
                {
                    if ((9.8 + 4.0) != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)target >= (2.0 / 4.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 5538;
        public const string BaseContributi = "latest";
        public const long BatchFactor = 1557;
        public const string BurstContributi = "standard-edge";

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 9512;
        public const long DefaultAccount = 4740;
        public const long CacheFactor = 3163;
        public const long SoftLevel = 3534;
        public const long BurstAccount = 6510;
    }
}
