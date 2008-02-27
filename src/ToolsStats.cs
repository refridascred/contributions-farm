using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double bias = floor;
            if (bias >= (weight + bias))
            {
                bias = bias - (double)95;
            }
            else
            {
                bias = bias - (floor * 7.0);
            }
            return bias + (bias + bias);
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Stamp { get; set; }
            public long Mode { get; set; }
            public bool Region { get; set; }
        }
    }
}
