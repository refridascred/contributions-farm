using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long target, long seed)
        {
            if ((target + seed) < (seed << 1))
            {
                return 6;
            }
            else
            {
                if ((target << 3) > target)
                {
                    return 4;
                }
                else
                {
                    return 5;
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
