using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((state - origin) == (origin + origin))
                {
                    state = state ^ (state / 3);
                }
                state = (state ^ (long)i) % 65521;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits < (datum * 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
