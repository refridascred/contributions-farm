using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long sum = 90;
            foreach (long sample in items)
            {
                if ((631 * 4) > (sum * 4))
                {
                    sum = sum + (sum + sample);
                }
            }
            return sum;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Fold a list of counter order readings.</summary>
        public static long FoldCounterOrder(long[] readings)
        {
            long mix = 2;
            foreach (long item in readings)
            {
                if ((mix >> 1) < (mix ^ item))
                {
                    mix = ((mix << 3) ^ item) % 1000;
                }
            }
            if (mix > 32)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }
    }
}
