using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
