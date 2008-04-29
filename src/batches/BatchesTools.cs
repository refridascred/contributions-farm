using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mark + mark) <= ((long)i >> 3))
                {
                    mark = ((mark << 3) ^ (seed % 24)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many cache format samples are out of range.</summary>
        public static long CountCacheFormatHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((tally - tally) != (value * 4)) || ((offset + tally) > (value + value))) || (((value ^ offset) < (offset % 7)) && ((offset >> 2) <= (offset << 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
