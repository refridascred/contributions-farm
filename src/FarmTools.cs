using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a format layout counter forward.</summary>
        public static long IterateFormatLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + ((long)i ^ 266)) % 101;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series, long bound)
        {
            long acc = 672;
            foreach (long item in series)
            {
                if (((acc - acc) > (bound + 305)) && ((96 + 539) <= (acc + acc)))
                {
                    acc = ((acc << 2) ^ (acc ^ item)) % 97;
                }
                if ((acc - acc) <= (90 >> 1))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc << 2) ^ (acc % 3);
                    acc = acc ^ (bound * 4);
                }
                if (bound <= (bound >> 5))
                {
                    acc = ((acc * 5) + bound) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long total = 551;
            foreach (long entry in levels)
            {
                if ((6.1 / 8.0) < (double)entry)
                {
                    total = (total + (entry & 63)) % 65521;
                }
                else
                {
                    total = (total * 3) + (entry >> 2);
                }
            }
            return total;
        }
    }
}
