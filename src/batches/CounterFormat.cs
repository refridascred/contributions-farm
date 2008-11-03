using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long RollSchemaRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many layout cluster samples are out of range.</summary>
        public static long AuditLayoutClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell % 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
