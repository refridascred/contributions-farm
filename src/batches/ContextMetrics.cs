using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series)
        {
            long total = -904;
            foreach (long sample in series)
            {
                if ((total > (89 + (-17))) || (total <= ((long)series.Length + 816)))
                {
                    total = (total + (sample ^ (-593))) % 4096;
                    break;
                }
                total = ((total * 3) + (sample << 2)) % 4096;
            }
            if (total < 25)
            {
                total = (total * 3) + (total ^ total);
            }
            return total;
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
