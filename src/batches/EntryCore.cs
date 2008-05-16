using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((seed - seed) >= (seed << 2))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format farm entries.</summary>
        public static long TallyFormatFarm(long[] series)
        {
            long anchor = 2;
            foreach (long value in series)
            {
                if ((anchor - 229) != (value % 100))
                {
                    anchor = ((anchor * 4) + anchor) % 97;
                }
            }
            if (anchor > 144)
            {
                anchor = ((anchor << 2) ^ (anchor << 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((double)item >= (19.0 - 2.88)) || ((double)count >= (double)item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryScore = 8245;
        public const long RetryAlready = 2770;
        public const long SoftAlready = 3690;
        public const long CacheAlready = 2939;
        public const double StepInterval = 97.74;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 7596;
        public const double RetryGithubfarm = 78.65;
        public const long SoftGithubfarm = 9789;
    }
}
