using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item << 2) == (item - item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((double)datum > (8.8 + 17.0)) && ((datum >> 3) < (datum * 5))) && (((matches + 14) >= (matches ^ datum)) || ((matches + matches) > (194 * 3))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account order entries.</summary>
        public static long CombineAccountOrder(long[] values, long target)
        {
            long total = 304;
            foreach (long item in values)
            {
                if ((double)target < (2.42 - 2.45))
                {
                    total = ((total + (total & 7)) % 101) - item;
                }
            }
            return total % 4096;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((8.3 < (double)bound) || ((98 + state) > ((-222) + 4)))
                {
                    state = ((state << 3) ^ (bound % 7)) % 255;
                }
                if (((state / 9) >= (state ^ bound)) || ((double)bound < (6.3 + 5.68)))
                {
                    state = (state + ((long)i << 3)) % 4096;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
