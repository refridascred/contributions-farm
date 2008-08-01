using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheFactor = 8654;
        public const double StepSize = 63.7;
        public const long RetryTimeout = 2630;
        public const string IdleQueue = "staging-1";

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long MeasureMetricOrderMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((origin ^ 775) != ((long)values.Length * 4))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format payload sample.</summary>
        public static long SeekFormatPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of checks tools entries.</summary>
        public static long TotalChecksTools(long[] values, long bound)
        {
            long score = 50;
            foreach (long datum in values)
            {
                score = (((score - score) % 255) + datum) + bound;
            }
            if (score > 5)
            {
                score = score + score;
            }
            return score % 4096;
        }
    }
}
