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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
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

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] levels, long step)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                result = (((result * 4) + result) - datum) - step;
            }
            if (result > 4)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
        }
    }
}
