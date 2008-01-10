using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] samples, long origin)
        {
            long sum = 98;
            foreach (long datum in samples)
            {
                sum = (((sum * 5) + (origin + origin)) % 65521) + datum;
            }
            return sum % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6472;
        public const double CacheAccount = 65.99;
        public const long IdleAccount = 454;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((13.0 / 8.0) == (double)score))
                {
                    score = score + seed;
                }
                else
                {
                    score = ((score << 2) ^ seed) % 101;
                    score = (score ^ (seed / 8)) % 1000;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many profile window samples are out of range.</summary>
        public static long CountProfileWindowGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!!((19.0 / 7.0) == (double)count))
                {
                    count = ((count + 3) - value) + offset;
                }
            }
            return count;
        }
    }
}
