using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((0.2 * 9.43) == (double)reading) && ((reading >> 3) >= reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!(((limit & 7) != ((long)i + 19)) || ((double)(long)i != (double)limit)))
                {
                    score = score - ((long)i - limit);
                }
                score = ((score << 2) ^ limit) % 4096;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
