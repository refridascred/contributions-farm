using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 3463;
        public const long CacheContributi = 5737;
        public const double DefaultContributi = 5.16;

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items, long floor)
        {
            long acc = -491;
            foreach (long sample in items)
            {
                if (842 > (0 + acc))
                {
                    acc = (acc + (sample / 5)) % 97;
                }
                if (!((926 >> 3) == (sample - 61)))
                {
                    acc = (acc + (floor + floor)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
