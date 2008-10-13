using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of command notes entries.</summary>
        public static long TallyCommandNotes(long[] samples)
        {
            long mix = 9;
            foreach (long item in samples)
            {
                if ((item >= (item ^ item)) || ((mix * 2) < mix))
                {
                    mix = (mix + (item + (-63))) % 101;
                }
            }
            if (mix > 11)
            {
                mix = ((mix * 3) + (mix >> 4)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the format githubfarm series from a seed.</summary>
        public static long IterateFormatGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = (total + total) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a order contributi counter forward.</summary>
        public static long SeriesOrderContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((offset - 906) != (offset % 2)))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
