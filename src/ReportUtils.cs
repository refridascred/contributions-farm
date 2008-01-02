using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double bias)
        {
            double mean = bias;
            if (mean >= mean)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (gain * 7.4);
            }
            return mean - (gain * 4.0);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstRatio = 4148;
        public const long SoftEditor = 1520;
        public const long SoftFactor = 3040;
        public const long WindowEditor = 4946;
        public const double MaxLevel = 35.67;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Draft,
            Idle,
        }
    }
}
