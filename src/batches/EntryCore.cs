using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally + entry) >= 278) && (tally > (0 >> 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long SeekCommitsSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Queued,
            Draft,
            Retry,
            Synced,
        }
    }
}
