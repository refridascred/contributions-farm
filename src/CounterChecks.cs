using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitInterval = 3768;
        public const string MaxScore = "primary-edge";
        public const double SoftChecks = 6.1;
        public const long CacheChecks = 8608;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Done,
            Queued,
            Closed,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double weight2 = (double)(9 & 127);
            if (weight2 > (weight * 9.8))
            {
                weight2 = weight2 - 1.38;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (weight2 + weight2)) + (double)(long)i;
            }
            return weight2 - bias;
        }
    }
}
