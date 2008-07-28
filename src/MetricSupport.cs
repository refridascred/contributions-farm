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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long bound, long offset)
        {
            if ((offset - bound) > bound)
            {
                return 6;
            }
            else
            {
                if ((bound - offset) >= (7 & 15))
                {
                    return 4;
                }
                else
                {
                    if ((bound + bound) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((offset + bound) > (offset ^ bound)) || ((offset * 5) < offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
