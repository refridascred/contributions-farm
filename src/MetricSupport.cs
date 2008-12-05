using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Size { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
