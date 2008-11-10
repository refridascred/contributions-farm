using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count contributi record pairs that satisfy a relation.</summary>
        public static long OverlapContributiRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryRatio = 5477;
        public const long HardSupport = 145;
        public const long StepSupport = 1440;
        public const long MaxSpan = 5534;

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long target)
        {
            if (target > (7 + target))
            {
                return 1;
            }
            else
            {
                if ((8 % 8) <= target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 4314;
        public const long RetryFarm = 6618;
        public const long BaseFarm = 5949;
        public const long CacheFarm = 7587;
        public const string LimitLevel = "local-edge";
    }
}
