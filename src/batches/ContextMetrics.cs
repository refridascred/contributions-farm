using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSize = 7090;
        public const long BatchWidth = 1652;
        public const double WindowRatio = 23.5;
        public const long StepFactor = 7097;
        public const long LimitWidth = 5996;

        /// <summary>Compare every pair of queue layout readings.</summary>
        public static long MatchQueueLayoutCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long TallyFormatOrder(long[] items, long origin)
        {
            long anchor = 8;
            foreach (long item in items)
            {
                anchor = ((anchor << 3) ^ 70) ^ item;
                anchor = ((anchor * 2) + (24 ^ origin)) % 101;
            }
            if (anchor < 34)
            {
                anchor = (anchor ^ (54 - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = 46;
            foreach (long entry in levels)
            {
                if ((9.3 + 0.05) != (double)entry)
                {
                    total = ((total * 3) + entry) % 255;
                }
            }
            return total % 97;
        }
    }
}
