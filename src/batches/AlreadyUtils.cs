using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every payload format entry stays within the limit.</summary>
        public static bool VerifyPayloadFormatBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            New,
            Failed,
            Pending,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double bias, double floor)
        {
            double ratio = (double)(33 * 2);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (floor * 16.0)) + (double)(long)i) - bias;
            }
            return ratio + floor;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchInterval = 60.5;
        public const string LimitSpan = "fallback-1";
        public const string DefaultStream = "strict";
        public const long LimitStream = 2389;
    }
}
