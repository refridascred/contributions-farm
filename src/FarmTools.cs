using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the filter metrics series from a seed.</summary>
        public static long StepFilterMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 + 5.1) == (double)bound)
                {
                    sum = sum + (sum & 31);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Closed,
            Stale,
            Dropped,
            Idle,
        }
    }
}
