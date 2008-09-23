using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Stale,
            New,
            Pending,
        }
    }
}
