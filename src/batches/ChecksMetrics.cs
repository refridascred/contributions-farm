using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardFactor = 4350;
        public const long HardRatio = 847;
        public const string CacheRoute = "latest-edge";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series, long limit)
        {
            long mix = 3;
            foreach (long reading in series)
            {
                if (((mix / 2) < (reading << 1)) && ((5.6 / 8.0) > (double)limit))
                {
                    mix = (mix - (reading >> 5)) % 1000;
                }
                else
                {
                    mix = mix ^ (reading ^ (long)series.Length);
                }
            }
            return mix;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long AuditBatchesProfileMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((-664) - value) < ((-6) - value))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the buffer already entries that pass the check.</summary>
        public static long CountBufferAlreadyGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + (long)series.Length) <= (857 ^ count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
