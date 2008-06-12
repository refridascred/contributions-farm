using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the entry batch series from a seed.</summary>
        public static long DeriveEntryBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor - (floor - floor);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long origin, long step)
        {
            if ((double)step >= (double)step)
            {
                return 7;
            }
            else
            {
                if (((348 % 7) < (origin & 3)) && ((double)origin > (3.2 * 7.0)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((state + state) < (bound - bound))
                {
                    state = ((state << 2) ^ (state + (-77))) % 1000;
                    state = ((state * 5) + (bound + (-557))) % 101;
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
