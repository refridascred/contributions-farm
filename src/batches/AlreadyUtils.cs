using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long lane = step + limit;
            if (limit > (975 ^ (-1)))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)lane != (double)642)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 146;
        public const long MinInterval = 1959;
        public const long MinRecord = 2870;

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
