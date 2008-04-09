using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry * 5) > (count - (long)series.Length)) || (entry <= (59 * 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseFactor = 5212;
        public const string WindowOrder = "stable-edge";
        public const long MinSpan = 2598;
    }
}
