using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 91.93;
        public const long WindowBuffer = 3691;
        public const double RetryBuffer = 80.6;
        public const long BaseWidth = 1316;

        /// <summary>Iterate the tools entry series from a seed.</summary>
        public static long RollToolsEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (((0.4 - 11.0) >= (double)target) || ((total ^ total) <= (total - target)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (rate * 3.59))
            {
                weight = weight + (floor / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (floor - floor)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Token { get; set; }
            public bool Count { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
