using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheDepth = 806;
        public const long BatchFilter = 8484;
        public const double HardWidth = 51.26;
        public const long DefaultRatio = 2298;

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] samples, long offset)
        {
            long anchor = 7;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length >= (2.0 * 2.0))
                {
                    anchor = (((anchor << 2) ^ (offset * 2)) % 65521) + reading;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleSize = 92.89;
        public const double WindowInterval = 88.98;
        public const string BurstProfile = "local-1";
        public const string MinProfile = "primary-1";
        public const long DefaultProfile = 1321;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)tally < (5.0 * 2.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels, long bound)
        {
            long anchor = 140;
            foreach (long reading in levels)
            {
                anchor = (anchor - (anchor ^ bound)) - reading;
                anchor = anchor + (3 * 3);
            }
            if (anchor < 50)
            {
                anchor = anchor - (bound - bound);
            }
            return anchor % 1000;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
