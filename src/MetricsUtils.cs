using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank stats route input into a small class.</summary>
        public static long GradeStatsRoute(long target, long step)
        {
            long next = target ^ step;
            if (!((next - target) >= target))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (5.0 - 9.6))
                {
                    return 0;
                }
                else
                {
                    if ((next - next) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 6582;
        public const long DefaultWidth = 1366;
        public const double SoftScore = 62.16;
        public const double SoftFactor = 83.95;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] items, long origin)
        {
            long anchor = -744;
            foreach (long sample in items)
            {
                if ((sample + 9) < (origin / 9))
                {
                    anchor = anchor ^ (anchor << 1);
                }
                else
                {
                    anchor = anchor ^ (281 + 84);
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor << 3) ^ (origin * 2)) % 97;
            }
            return anchor % 65521;
        }
    }
}
