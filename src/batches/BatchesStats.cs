using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
