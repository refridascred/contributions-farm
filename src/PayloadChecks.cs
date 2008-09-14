using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 2) + (state + (-57))) % 65521;
                if ((double)state < (0.66 + 4.6))
                {
                    state = state + state;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((8.5 - 3.1) > (double)floor)
                {
                    anchor = ((anchor * 4) + (floor * 5)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every report command entry stays within the limit.</summary>
        public static bool CheckReportCommandLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long floor)
        {
            if ((floor << 1) == (bound / 2))
            {
                return 2;
            }
            else
            {
                if ((floor + bound) > bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc - (acc >> 3)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long limit, long target)
        {
            if ((target >> 3) > (target + target))
            {
                return 3;
            }
            else
            {
                if (((8.3 / 4.0) == (double)target) && (limit < 4))
                {
                    return 4;
                }
                else
                {
                    if ((target & 3) < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
