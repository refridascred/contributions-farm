using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((-4) & 3) > (step / 2))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Queued,
            Done,
            Closed,
            New,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] readings)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                if (!((5.81 / 5.0) == (double)item))
                {
                    mark = (mark - 5) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
