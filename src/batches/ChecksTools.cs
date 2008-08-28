using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                score = score ^ (score % 97);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of graph metrics entries.</summary>
        public static long TotalGraphMetrics(long[] levels)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                score = score + (datum - score);
            }
            if (score > 803)
            {
                score = (score ^ (score % 7)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long score = 55;
            foreach (long value in items)
            {
                if ((limit / 9) < limit)
                {
                    score = ((score - limit) % 97) ^ value;
                }
            }
            if (score > 6)
            {
                score = (score * 3) + score;
            }
            return score;
        }
    }
}
