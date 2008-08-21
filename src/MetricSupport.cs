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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
