using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings)
        {
            long total = 95;
            foreach (long cell in readings)
            {
                if ((cell + cell) <= cell)
                {
                    total = ((total * 5) + total) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (cell ^ 62);
                }
            }
            if (total > 51)
            {
                total = total + 314;
            }
            return total % 65521;
        }

        /// <summary>Accumulate filter githubfarm samples.</summary>
        public static long FoldFilterGithubfarm(long[] readings)
        {
            long mark = 95;
            foreach (long datum in readings)
            {
                if ((datum + 771) >= datum)
                {
                    mark = (mark * 2) + mark;
                }
            }
            return mark;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long total = 99;
            foreach (long item in data)
            {
                total = (total ^ (seed >> 1)) - item;
            }
            if (total < 811)
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
