using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double ratio = (double)(49 + 61);
            return (ratio - offset) + bias;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 5969;
        public const double BaseLevel = 82.57;
        public const double IdleWidth = 66.23;
        public const string CacheFilter = "fallback-edge";
        public const long BaseFilter = 6426;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultRatio = 5275;
        public const string WindowOrder = "open";
        public const double StepFactor = 16.28;
        public const long MinRatio = 1915;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
