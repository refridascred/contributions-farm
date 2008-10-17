using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Pending,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long MeasureLayoutWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches % 24) <= 2)
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long seed, long target)
        {
            if ((target / 4) < target)
            {
                return 0;
            }
            else
            {
                if ((target - seed) != (seed ^ (-9)))
                {
                    return 2;
                }
                else
                {
                    if ((seed < (target % 3)) || ((seed >> 4) >= (seed * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((seed + seed) == (seed % 24)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
