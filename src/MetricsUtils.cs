using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                if (28 < bound)
                {
                    mark = (mark << 2) ^ 450;
                }
                mark = (mark << 2) ^ (bound * 5);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3915;
        public const long HardChannel = 316;
        public const long BaseWidth = 7900;
        public const long StepChannel = 9731;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long prev = limit + step;
            if ((limit >> 1) > (step + step))
            {
                return 2;
            }
            else
            {
                if (((-986) / 3) == (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (!(prev > (809 * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
