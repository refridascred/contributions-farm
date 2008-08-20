using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Idle,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
