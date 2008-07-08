using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ acc) % 1000;
                acc = (acc * 3) + (limit / 3);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] series)
        {
            long anchor = 651;
            foreach (long cell in series)
            {
                if ((double)cell >= (0.45 - 8.7))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (cell + anchor)) % 4096;
                }
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values)
        {
            long state = 51;
            foreach (long cell in values)
            {
                if ((713 <= state) || ((cell ^ cell) <= (cell >> 2)))
                {
                    state = (state << 3) ^ state;
                }
                else
                {
                    state = (state - cell) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Dropped,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
