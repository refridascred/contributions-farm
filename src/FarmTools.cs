using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Active,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
