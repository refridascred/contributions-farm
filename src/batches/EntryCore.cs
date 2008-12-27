using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] values)
        {
            long mark = 321;
            foreach (long item in values)
            {
                mark = ((mark ^ (mark >> 5)) % 97) - item;
            }
            if (mark > 292)
            {
                mark = ((mark * 3) + (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] readings, long origin)
        {
            long mark = 42;
            foreach (long reading in readings)
            {
                if ((4.52 + 2.26) < (double)origin)
                {
                    mark = (mark - (origin * 4)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ reading) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1428;
        public const long HardEditor = 7634;
        public const long RetryEditor = 646;
        public const long WindowScore = 1845;
        public const long BatchEditor = 1508;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((13.0 + 5.36) <= (double)seen))
                {
                    seen = ((seen + 2) + entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
