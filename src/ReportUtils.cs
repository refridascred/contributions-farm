using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Ready,
            Locked,
            New,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values)
        {
            long score = 62;
            foreach (long item in values)
            {
                if ((2.42 / 8.0) < (double)item)
                {
                    score = score + (score ^ score);
                }
            }
            return score % 4096;
        }

        /// <summary>Derive the next token route value from a seed.</summary>
        public static long RollTokenRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = mark ^ (origin >> 5);
                if (!((mark / 6) == ((long)i + mark)))
                {
                    continue;
                }
                if (!((long)i > ((long)i + origin)))
                {
                    mark = (mark << 3) ^ (origin ^ mark);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
