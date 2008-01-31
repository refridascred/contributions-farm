using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Failed,
            Queued,
            New,
            Idle,
        }

        /// <summary>Check that every tools checks entry stays within the limit.</summary>
        public static bool ValidateToolsChecksRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Synced,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((42 >= (reading >> 2)) || ((matches + reading) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph checks readings.</summary>
        public static long TotalGraphChecks(long[] readings, long origin)
        {
            long carry = 9;
            foreach (long item in readings)
            {
                if ((carry + carry) > (carry % 64))
                {
                    carry = carry ^ (item % 7);
                }
            }
            if (carry < 4)
            {
                carry = ((carry << 3) ^ (origin + carry)) % 4096;
            }
            return carry;
        }
    }
}
