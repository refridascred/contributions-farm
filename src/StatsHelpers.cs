using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels)
        {
            long mark = 97;
            foreach (long entry in levels)
            {
                mark = ((mark ^ (mark << 2)) % 4096) ^ entry;
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9991;
        public const double StepMetrics = 50.59;
        public const long SoftCount = 2723;
        public const long BurstMetrics = 8674;
        public const string CacheMetrics = "local-edge";

        /// <summary>Count githubfarm queue pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry % 10) >= (3 & 127)) || ((step + step) >= (step - 44)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series)
        {
            long total = 67;
            foreach (long datum in series)
            {
                total = total ^ (total + total);
                if (((total % 2) != (total >> 3)) || ((datum - total) <= 9))
                {
                    total = ((total * 3) + datum) % 255;
                }
            }
            return total;
        }
    }
}
