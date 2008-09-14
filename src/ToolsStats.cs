using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Closed,
            Stale,
            Pending,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if ((mark <= (5 << 2)) || ((mark - mark) >= step))
                {
                    continue;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark % 100)) % 255;
                    mark = ((mark << 3) ^ mark) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a entry metrics sample.</summary>
        public static long FindEntryMetricsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepAccount = "alpha-v2";
        public const double BaseAccount = 79.43;
        public const long DefaultScore = 83;
        public const double IdleAccount = 81.57;
        public const long MinSize = 2607;
    }
}
