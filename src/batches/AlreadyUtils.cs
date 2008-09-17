using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Ready,
            Queued,
            Failed,
            Closed,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + limit) % 4096;
                anchor = ((anchor * 4) + (limit * 5)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count & 15) <= (count - (-7)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Draft,
            Retry,
            Stale,
        }
    }
}
