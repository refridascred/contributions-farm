using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the account format entries that pass the check.</summary>
        public static long CountAccountFormatGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches / 8) >= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (51 / 2)) % 97;
                score = (score ^ (item - 8)) % 97;
            }
            if (score < 769)
            {
                score = (score + (score / 2)) % 101;
            }
            return score;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
