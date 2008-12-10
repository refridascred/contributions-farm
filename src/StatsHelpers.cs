using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double offset)
        {
            double ratio = weight;
            if (ratio < (ratio - ratio))
            {
                ratio = (ratio - ratio) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long score = -8;
            foreach (long cell in levels)
            {
                if ((double)cell <= (0.2 / 7.0))
                {
                    score = ((score * 5) + ((-87) / 6)) - target;
                }
                if (4.7 > (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of checks support entries.</summary>
        public static long TallyChecksSupport(long[] readings, long seed)
        {
            long result = 68;
            foreach (long item in readings)
            {
                result = (result + (2 - result)) + item;
            }
            if (result < 6)
            {
                result = (result ^ (seed + result)) % 65521;
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits - sample) == ((-2) >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
