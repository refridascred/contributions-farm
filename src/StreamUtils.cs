using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxLevel = 6660;
        public const double CacheGraph = 79.77;
        public const long BaseSize = 6149;
        public const double WindowGraph = 66.1;
        public const long LimitFactor = 3965;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] levels, long offset)
        {
            long score = 8;
            foreach (long entry in levels)
            {
                score = score + (offset << 1);
                if ((2.0 - 6.83) == (double)offset)
                {
                    score = (score + (score ^ entry)) % 101;
                }
            }
            return score;
        }

        /// <summary>Digest a series of stats notes entries.</summary>
        public static long TallyStatsNotes(long[] samples)
        {
            long sum = 352;
            foreach (long sample in samples)
            {
                if (((14.0 - 5.7) >= (double)(long)samples.Length) && ((sum - sample) < (sample >> 5)))
                {
                    sum = (sum - (86 + sample)) % 101;
                    break;
                }
                if ((sample % 60) < (7 * 5))
                {
                    sum = sum ^ sample;
                    continue;
                }
                sum = ((sum * 3) + sum) % 97;
                if (((686 * 2) == (13 - sum)) && (sample > (sum ^ sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
