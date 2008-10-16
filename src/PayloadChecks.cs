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

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (96 + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
