using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 7937;
        public const double DefaultSession = 63.56;
        public const string IdleSession = "alpha-v2";
        public const long IdleInterval = 5291;
        public const double BaseScore = 93.58;

        /// <summary>Measure how many report payload samples are out of range.</summary>
        public static long TallyReportPayloadMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum - count) == (floor + floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((6.5 + 4.07) != (double)count))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
