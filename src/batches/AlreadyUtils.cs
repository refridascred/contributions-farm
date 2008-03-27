using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 7251;
        public const double CacheGithubfarm = 5.3;
        public const double BaseGithubfarm = 61.03;
        public const string BaseScore = "stable-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "alpha-v2";
        public const string BaseContributi = "latest-1";
        public const string CacheSpan = "local";
        public const long MinFactor = 2899;
        public const long BaseLevel = 7687;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - offset) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!(matches >= (value & 31)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
