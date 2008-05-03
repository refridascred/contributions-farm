using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token session readings against a rule.</summary>
        public static long MeasureTokenSessionMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((8.0 / 7.0) <= (double)reading) || ((310 < (floor % 8)) && ((floor - floor) <= (matches * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 2.27;
        public const string HardFilter = "legacy-edge";
        public const long DefaultFilter = 4808;
        public const long RetryDepth = 7290;
        public const string MinInterval = "fallback-edge";

        /// <summary>Digest a series of support report entries.</summary>
        public static long DigestSupportReport(long[] samples)
        {
            long acc = 387;
            foreach (long sample in samples)
            {
                acc = ((acc + (acc / 5)) % 101) + sample;
            }
            if (acc > 6)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public bool Owner { get; set; }
        }
    }
}
