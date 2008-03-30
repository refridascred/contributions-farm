using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Queued,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
