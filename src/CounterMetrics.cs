using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Done,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Check that every schema route entry stays within the limit.</summary>
        public static bool GuardSchemaRouteRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Done,
            Stale,
        }
    }
}
