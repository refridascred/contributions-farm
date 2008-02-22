using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] samples)
        {
            long score = 62;
            foreach (long cell in samples)
            {
                score = score + cell;
                if (((score - 4) <= score) && (cell > (score << 1)))
                {
                    score = (score - (-7)) % 65521;
                }
            }
            if (score > (-99))
            {
                score = (score - (score + score)) % 255;
            }
            return score;
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
