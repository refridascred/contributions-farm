using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long offset)
        {
            long sum = -30;
            foreach (long cell in series)
            {
                sum = (((sum + sum) % 65521) - cell) - offset;
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long bound)
        {
            if (7.0 >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((bound / 6) >= floor)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every notes batch entry stays within the limit.</summary>
        public static bool ValidateNotesBatchBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
