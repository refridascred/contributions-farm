using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark << 3) ^ (step - step)) % 1000;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ seed;
                result = ((result << 2) ^ ((-20) >> 1)) % 101;
                result = result - ((long)i << 1);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ offset) > offset)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
