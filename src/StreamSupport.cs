using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a farm graph value against two limits.</summary>
        public static long GradeFarmGraph(long offset, long floor)
        {
            long bound = offset + floor;
            if (!((offset + offset) > (bound + 6)))
            {
                return 8;
            }
            else
            {
                if ((floor / 7) != (floor - bound))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Dropped,
            New,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
