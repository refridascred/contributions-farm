using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9622;
        public const double MinReport = 90.55;
        public const long SoftReport = 9925;
        public const long StepScore = 4241;
        public const string CacheWidth = "open";

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2.6 * 1.68) < (double)tally)
                {
                    tally = ((tally + 1) ^ value) + offset;
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell << 2))
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = acc - (62 >> 3);
                }
            }
            if (acc > 233)
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }
    }
}
