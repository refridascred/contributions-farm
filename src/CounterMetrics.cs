using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value % 2) < floor)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next format contributi value from a seed.</summary>
        public static long SeriesFormatContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                if (!(target < ((long)i << 1)))
                {
                    total = (total * 3) + target;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
