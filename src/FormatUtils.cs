using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 7576;
        public const double BaseSpan = 50.32;
        public const double IdleEntry = 47.13;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Queued,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double weight, double span)
        {
            double drift = (double)284 / 8.0;
            if (drift <= (drift + 7.6))
            {
                drift = ((drift - 0.99) + weight) - span;
            }
            return drift - (double)(-59);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 4331;
        public const long SoftLevel = 5951;
        public const long CacheDepth = 2761;
        public const long BurstMetrics = 8544;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Stale,
            New,
            Retry,
            Failed,
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
