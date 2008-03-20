using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((origin / 7) <= (5 % 60)) || (((origin * 5) != (tally % 8)) && ((double)tally < (7.81 - 18.0))))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Queued,
            Active,
            Done,
            Closed,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (offset <= 2)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
