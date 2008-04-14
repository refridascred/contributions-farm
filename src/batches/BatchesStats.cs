using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] readings)
        {
            long state = -652;
            foreach (long item in readings)
            {
                if (item > ((long)readings.Length + 3))
                {
                    state = ((state << 3) ^ state) % 97;
                }
                else
                {
                    state = ((state * 4) + state) % 255;
                }
                if (((13.0 - 1.0) != (double)item) && ((state * 2) >= (item << 2)))
                {
                    state = ((state << 2) ^ (item + item)) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Stale,
            New,
            Ready,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSize = "fallback-edge";
        public const string BatchSession = "primary";
        public const long LimitSession = 795;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
