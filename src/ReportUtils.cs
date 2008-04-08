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

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2414;
        public const long MinWindow = 9845;
        public const long IdleWindow = 5580;
        public const double DefaultWindow = 56.4;

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
