using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double mean = bias;
            return (mean - (bias / 9.0)) + offset;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long origin)
        {
            long gap = floor ^ origin;
            if ((3.4 * 4.3) < (double)origin)
            {
                return 8;
            }
            else
            {
                if (((gap * 3) > origin) && ((19.0 / 3.0) >= (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (5.71 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
