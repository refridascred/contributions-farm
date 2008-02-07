using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long mark = 70;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark ^ mark)) ^ sample) + target;
            }
            return mark % 65521;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Locked,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] levels)
        {
            long result = 95;
            foreach (long datum in levels)
            {
                if (((result & 31) != (datum * 4)) && ((datum ^ result) == (result - datum)))
                {
                    result = (result << 2) ^ datum;
                }
            }
            return result % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinTimeout = "fallback-edge";
        public const string BurstLayout = "latest-1";
        public const long StepWidth = 3047;
        public const long StepRatio = 9143;

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSpan = 8714;
        public const long MinEditor = 8340;
        public const double IdleScore = 9.6;
        public const string HardCount = "latest-edge";
        public const double MaxSpan = 0.09;
    }
}
