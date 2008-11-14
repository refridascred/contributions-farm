using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 16;
        public const double HardInterval = 43.35;
        public const long StepLayout = 3010;
        public const long MinCount = 8371;
        public const string BurstFactor = "alpha-edge";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long limit)
        {
            long sum = 537;
            foreach (long sample in data)
            {
                sum = ((sum ^ (limit + 7)) % 1000) ^ sample;
                sum = (sum + 19) % 65521;
            }
            return sum;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((((floor << 1) == (floor & 31)) || ((floor + datum) < datum)) || (((9.1 / 2.0) >= (double)datum) || ((matches ^ (long)levels.Length) >= floor)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next stats batches value from a seed.</summary>
        public static long DeriveStatsBatches(long step)
        {
            long mark = step;
            for (int i = 0; i < 10; i++)
            {
                mark = mark + mark;
                mark = (mark ^ ((long)i / 8)) % 65521;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
