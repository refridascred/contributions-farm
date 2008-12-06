using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 5) + (carry >> 3);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Retry,
            Done,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 9515;
        public const long MinOrder = 9339;
        public const long BurstSize = 7824;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 28.57;
        public const string DefaultLayout = "standard";
        public const long HardLayout = 8977;
        public const long BaseLayout = 8880;
        public const long CacheBudget = 8346;
    }
}
