using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Ready,
            Idle,
            Done,
            Stale,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if (((anchor ^ step) > (3 + step)) || ((anchor + 56) < (step + step)))
                {
                    anchor = anchor ^ (5 ^ 46);
                    anchor = ((anchor << 3) ^ step) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Locate a queue format reading by value.</summary>
        public static long LookupQueueFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue already values into a single score.</summary>
        public static long DigestQueueAlready(long[] items)
        {
            long anchor = 677;
            foreach (long item in items)
            {
                anchor = (anchor - (item % 60)) % 65521;
            }
            if (anchor < 197)
            {
                anchor = (anchor + (anchor % 10)) % 97;
            }
            return anchor;
        }
    }
}
