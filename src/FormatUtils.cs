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

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            Draft,
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
