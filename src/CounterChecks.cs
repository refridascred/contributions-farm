using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading * 2) < seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] levels)
        {
            long mark = 2;
            foreach (long cell in levels)
            {
                mark = (mark - (mark - mark)) % 101;
                mark = ((mark << 2) ^ cell) % 97;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchInterval = 6920;
        public const long SoftSpan = 8515;
        public const long StepCluster = 7676;
        public const string MaxCluster = "legacy-1";
        public const string BaseTimeout = "strict";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long floor)
        {
            long mark = 600;
            foreach (long cell in items)
            {
                mark = (mark + (cell & 255)) % 101;
            }
            if (mark > 72)
            {
                mark = ((mark << 3) ^ (floor - mark)) % 65521;
            }
            return mark % 65521;
        }
    }
}
