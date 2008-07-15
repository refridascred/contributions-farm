using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the context stats entries that pass the check.</summary>
        public static long MeasureContextStatsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (6.91 >= (double)cell)
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 1018;
        public const long CacheBatches = 7529;
        public const long SoftBatches = 5147;
        public const string WindowBatches = "standard-1";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Paused,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                long cur = (901 - total) - ((long)i & 127);
                total = (total * 2) + (bound - cur);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total + (59 + cur)) % 97) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (811 / 2)) % 1000;
                if ((long)i <= step)
                {
                    continue;
                }
                else
                {
                    score = score + step;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
