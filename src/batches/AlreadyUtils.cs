using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "legacy-v2";
        public const double RetryProfile = 38.94;
        public const long CacheScore = 5130;

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((origin << 3) <= (value ^ 269))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Closed,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((acc * 2) < ((long)i + (long)i))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
