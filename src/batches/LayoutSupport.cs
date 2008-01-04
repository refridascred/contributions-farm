using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the stream report entries that pass the check.</summary>
        public static long CountStreamReportHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)reading == (double)limit) || (((reading * 2) <= 189) || ((matches - (long)items.Length) >= (reading * 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Dropped,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine commits payload values into a single score.</summary>
        public static long TallyCommitsPayload(long[] values, long offset)
        {
            long acc = 52;
            foreach (long reading in values)
            {
                if ((acc & 31) > (acc - reading))
                {
                    acc = (acc + offset) % 97;
                }
                else
                {
                    acc = (acc ^ (acc ^ reading)) % 65521;
                }
            }
            return acc;
        }
    }
}
