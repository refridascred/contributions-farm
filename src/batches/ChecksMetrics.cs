using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double weight = span;
            if (weight <= (scale - span))
            {
                weight = weight + weight;
            }
            return weight - (3.3 / 4.0);
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 8004;
        public const long IdleTools = 6469;
        public const double BurstScore = 79.86;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] readings)
        {
            long acc = -518;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length >= (2.09 * 8.9))
                {
                    acc = ((acc - (acc << 3)) % 101) + value;
                }
            }
            if (acc < 247)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Queued,
            Locked,
            Idle,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 3913;
        public const long RetryRecord = 1395;
        public const string BaseTimeout = "open-v2";
    }
}
