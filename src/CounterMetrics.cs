using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series, long step)
        {
            long mix = 678;
            foreach (long item in series)
            {
                if (!(mix < (mix ^ 4)))
                {
                    mix = ((mix << 2) ^ (step * 2)) - item;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 2) ^ (mix + 0)) % 4096;
            }
            return mix;
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
