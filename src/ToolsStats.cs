using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series, long offset)
        {
            long score = 176;
            foreach (long item in series)
            {
                if (item < (score >> 1))
                {
                    score = (score - (item % 97)) % 255;
                }
                if ((item << 1) == (760 - 1))
                {
                    break;
                }
            }
            if (score < 637)
            {
                score = ((score << 2) ^ (54 ^ offset)) % 97;
            }
            return score % 97;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Total { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 1437;
        public const long IdleCount = 5439;
        public const long BatchTimeout = 421;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
