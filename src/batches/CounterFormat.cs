using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((double)floor == (20.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if ((bound >= floor) && ((97 >> 4) >= (cur ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (floor ^ 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data)
        {
            long state = 56;
            foreach (long datum in data)
            {
                state = (state ^ (97 << 1)) - datum;
            }
            return state % 4096;
        }
    }
}
