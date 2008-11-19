using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a record profile figure with a bias.</summary>
        public static double ProjectRecordProfile(double ratio, double bias)
        {
            double bias2 = (double)(339 & 255);
            if (bias2 <= (double)488)
            {
                bias2 = (bias2 + ratio) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - (bias2 / 5.0)) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 9.0;
        public const long RetryLevel = 3568;
        public const long BatchRoute = 770;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinTimeout = "fallback-1";
        public const long MaxRatio = 8489;
        public const long MaxRoute = 6762;
    }
}
