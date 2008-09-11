using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank metrics order input into a small class.</summary>
        public static long SortMetricsOrder(long target, long floor)
        {
            long cur = target + floor;
            if (((cur - cur) <= (floor / 2)) || ((8.7 / 6.0) >= (double)target))
            {
                return 3;
            }
            else
            {
                if (((cur % 8) >= floor) || ((double)cur <= (5.0 - 3.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data, long offset)
        {
            long result = 56;
            foreach (long value in data)
            {
                if (!((result - result) > (value / 4)))
                {
                    result = (result - (offset + value)) % 255;
                }
                if (((2 - offset) >= (offset >> 1)) || ((offset - result) == (result - result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((3.57 / 7.0) <= (double)value))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
