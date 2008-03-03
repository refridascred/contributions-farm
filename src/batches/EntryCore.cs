using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((683 * 2) < (floor + datum)) && ((13.0 - 9.0) > (double)hits)) || ((datum / 7) > (hits * 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheScore = "cached-edge";
        public const long SoftBuffer = 7206;
        public const string BaseWidth = "stable-1";
        public const long BatchBuffer = 3079;

        /// <summary>Validate record queue readings against a bound.</summary>
        public static bool VerifyRecordQueueRange(long[] data, long step)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            New,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long offset)
        {
            long state = 8;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state + (value - (long)i)) % 101;
                    state = (state * 5) + (value & 3);
                }
                if ((value & 3) < value)
                {
                    state = (state + (offset - offset)) % 255;
                }
            }
            if (state > 8)
            {
                state = (state - offset) % 101;
            }
            return state % 65521;
        }
    }
}
