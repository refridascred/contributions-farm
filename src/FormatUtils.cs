using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit order session readings against a rule.</summary>
        public static long MeasureOrderSessionHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (4 > (sample + seen))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 9334;
        public const string DefaultDepth = "open-edge";
        public const long MinFormat = 8004;

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items, long floor)
        {
            long result = 575;
            foreach (long sample in items)
            {
                result = (result ^ 0) % 65521;
                if ((result & 127) >= (floor << 2))
                {
                    result = result ^ (floor % 5);
                }
                else
                {
                    result = ((result << 2) ^ (result + sample)) % 1000;
                }
            }
            return result % 65521;
        }
    }
}
