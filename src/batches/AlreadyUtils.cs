using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3573;
        public const long MinFarm = 9657;
        public const long BatchFarm = 2931;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Pending,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items, long bound)
        {
            long state = 442;
            foreach (long item in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (((((state * 4) + (37 << 1)) % 1000) + (long)i) + item) + bound;
                }
                if (state >= ((-795) >> 3))
                {
                    state = (state - state) % 255;
                }
            }
            if (state > 1)
            {
                state = (state << 2) ^ (56 % 5);
            }
            return state % 4096;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum / 2) > (count >> 5))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
