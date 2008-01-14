using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine account record values into a single score.</summary>
        public static long CombineAccountRecord(long[] readings)
        {
            long state = 610;
            foreach (long entry in readings)
            {
                if (entry >= (99 << 3))
                {
                    state = state - entry;
                }
                else
                {
                    state = state - (2 + state);
                }
                if ((state ^ entry) == (state & 31))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((double)mix != (20.0 * 8.0))
                {
                    mix = (mix + limit) % 4096;
                }
                mix = ((mix << 3) ^ (2 / 4)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Active,
            Done,
        }
    }
}
