using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate order window readings against a bound.</summary>
        public static bool GuardOrderWindowRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next queue record value from a seed.</summary>
        public static long SeriesQueueRecord(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i * 3) >= state)
                {
                    state = (state + ((long)i - origin)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long bound)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total - (total + sample)) % 97) + bound;
            }
            if (total > 23)
            {
                total = total + (total * 4);
            }
            return total % 65521;
        }
    }
}
