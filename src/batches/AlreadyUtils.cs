using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long bound2)
        {
            if ((double)bound2 > (8.54 + 7.78))
            {
                return 6;
            }
            else
            {
                if ((bound2 - bound) == (bound2 % 10))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long bound)
        {
            long mark = -14;
            foreach (long datum in readings)
            {
                mark = ((mark - mark) ^ datum) - bound;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] samples)
        {
            long mark = 91;
            foreach (long cell in samples)
            {
                mark = (mark ^ (cell ^ cell)) % 4096;
                if ((long)samples.Length == (mark - cell))
                {
                    mark = (mark ^ cell) % 101;
                }
            }
            return mark;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (seed ^ cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
