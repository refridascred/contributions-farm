using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 2) ^ ((long)i % 12);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
