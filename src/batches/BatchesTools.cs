using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Done,
            Queued,
            Active,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
