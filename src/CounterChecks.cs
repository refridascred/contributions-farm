using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchLevel = "stable";
        public const long CacheChecks = 7975;
        public const long MinChecks = 1146;
        public const long BurstRatio = 3886;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double gain = scale;
            if (gain < (gain + scale))
            {
                gain = (gain + (gain / 4.0)) - floor;
            }
            else
            {
                gain = gain - (11.0 + scale);
            }
            return gain + (scale * 4.0);
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
