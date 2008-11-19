using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Roll a metric metrics counter forward.</summary>
        public static long IterateMetricMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                if (total <= (total + bound))
                {
                    total = (total ^ 47) % 255;
                    continue;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Queued,
            Active,
        }
    }
}
