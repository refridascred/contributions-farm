using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)714 > (double)cell)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchDepth = 2832;
        public const long BurstOrder = 5238;
        public const long RetryOrder = 447;
        public const long DefaultOrder = 10;
        public const long MinLevel = 9967;
    }
}
