using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first route schema entry that matches the target.</summary>
        public static long LookupRouteSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
