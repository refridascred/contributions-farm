using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample == (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen < (cell - cell)) || ((seed - cell) != (3 ^ seed)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits > datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
