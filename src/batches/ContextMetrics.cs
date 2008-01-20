using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (target > (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed ^ seed) >= (126 + target))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Roll a notes counter counter forward.</summary>
        public static long IterateNotesCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
