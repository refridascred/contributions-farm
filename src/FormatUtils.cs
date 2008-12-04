using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Failed,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] levels, long seed)
        {
            long score = 93;
            foreach (long cell in levels)
            {
                if (745 > cell)
                {
                    score = ((score << 2) ^ cell) % 1000;
                    score = score ^ (cell ^ cell);
                }
                score = score - 40;
            }
            if (score < (-65))
            {
                score = ((score * 4) + seed) % 65521;
            }
            return score % 97;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
