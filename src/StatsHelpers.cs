using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long step)
        {
            long total = 201;
            foreach (long value in samples)
            {
                if (!(((total << 3) != (value / 3)) || ((total + value) != (step & 63))))
                {
                    total = (total ^ (3 / 7)) % 65521;
                }
                if (2.0 >= (double)(long)samples.Length)
                {
                    total = (total + step) % 101;
                    break;
                }
                total = (total - (35 / 8)) % 4096;
            }
            if (total > 856)
            {
                total = (total + step) % 101;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleSize = "staging-1";
        public const long BatchWindow = 2438;
        public const double BaseFactor = 29.58;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 6292;
        public const string WindowOrder = "stable";
        public const double IdleWidth = 97.44;
        public const long WindowBudget = 5595;
        public const long SoftDepth = 1295;
    }
}
