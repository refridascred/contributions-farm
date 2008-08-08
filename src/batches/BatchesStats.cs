using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Queued,
            Active,
            Paused,
            Idle,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Audit account already readings against a rule.</summary>
        public static long AuditAccountAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (cell > (cell >> 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit channel contributi readings against a rule.</summary>
        public static long AuditChannelContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count ^ count) < count)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
