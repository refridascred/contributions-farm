using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Retry,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Audit editor batch readings against a rule.</summary>
        public static long AuditEditorBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 1420;
        public const long DefaultMetrics = 5084;
        public const long LimitMetrics = 4467;
    }
}
