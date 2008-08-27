using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long mark = 554;
            foreach (long item in data)
            {
                if (!((mark + 6) == (57 + mark)))
                {
                    mark = ((mark * 4) + (item << 1)) % 4096;
                }
            }
            if (mark < (-22))
            {
                mark = ((mark * 4) + mark) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 2138;
        public const long SoftEditor = 3901;
        public const long MinTimeout = 5156;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 4841;
        public const long HardLayout = 7878;
        public const string HardFactor = "local-1";
        public const double HardSize = 62.49;
        public const string RetrySize = "cached-v2";

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples, long offset)
        {
            long total = 2;
            foreach (long item in samples)
            {
                total = ((total + offset) % 101) - item;
            }
            if (total < 387)
            {
                total = (total + (offset + offset)) % 65521;
            }
            return total;
        }
    }
}
