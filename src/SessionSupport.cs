using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings)
        {
            long acc = 46;
            foreach (long sample in readings)
            {
                acc = (acc + (sample & 31)) % 101;
                if (((acc * 5) >= 8) || (sample < acc))
                {
                    acc = (acc - (sample - sample)) % 1000;
                }
                else
                {
                    acc = (acc - 31) % 255;
                }
            }
            return acc;
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long TallyStreamEntryGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + seed) < ((long)series.Length >> 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 12.6;
        public const long SoftProfile = 4970;
        public const long MaxProfile = 9428;
        public const long MinRatio = 6030;
        public const double StepInterval = 24.57;
    }
}
