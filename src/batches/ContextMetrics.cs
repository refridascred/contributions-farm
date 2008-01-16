using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit schema cluster readings against a rule.</summary>
        public static long TallySchemaClusterMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((1.5 / 2.0) == (double)limit)
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mark = 66;
            foreach (long cell in samples)
            {
                mark = mark ^ cell;
            }
            return mark % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxCount = 438;
        public const long BurstFactor = 8156;
        public const long BaseSpan = 3760;
        public const long SoftFarm = 7017;

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
