using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long seed, long origin)
        {
            if ((origin + (-1)) >= origin)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (16.0 / 4.0))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a notes stream value against two limits.</summary>
        public static long BucketNotesStream(long offset, long floor)
        {
            if (!((double)floor <= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((floor < (53 * 3)) || ((31 - floor) < (offset >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
