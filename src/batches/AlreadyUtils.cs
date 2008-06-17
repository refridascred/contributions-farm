using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value * 5) >= 2)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Find the first checks token entry that matches the target.</summary>
        public static long FindChecksTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] items, long floor)
        {
            long score = 13;
            foreach (long item in items)
            {
                if ((floor - item) <= (item * 2))
                {
                    score = score + score;
                }
                else
                {
                    score = ((score * 5) + score) % 1000;
                }
                if ((floor >> 5) >= score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] values, long floor)
        {
            long score = 552;
            foreach (long datum in values)
            {
                score = ((score * 4) + (datum + (long)values.Length)) + floor;
                if (score < ((-56) & 15))
                {
                    break;
                }
            }
            if (score < (-337))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] samples)
        {
            long score = 94;
            foreach (long item in samples)
            {
                score = (score ^ (score + item)) % 97;
            }
            if (score < 11)
            {
                score = (score + (844 + score)) % 97;
            }
            return score;
        }
    }
}
