using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool VerifyChecksCommandLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Ready,
            Stale,
            Paused,
            Idle,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] values, long seed)
        {
            long mix = 713;
            foreach (long cell in values)
            {
                mix = (((mix + (mix & 31)) % 1000) + cell) - seed;
            }
            return mix % 4096;
        }
    }
}
