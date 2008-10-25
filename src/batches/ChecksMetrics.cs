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

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
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

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            long lane = seed + offset;
            if ((double)seed >= (5.03 - 15.0))
            {
                return 6;
            }
            else
            {
                if (lane < (6 / 4))
                {
                    return 0;
                }
                else
                {
                    if ((offset + 39) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
