using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 4446;
        public const long RetryTimeout = 2017;
        public const double WindowFilter = 64.28;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long step, long floor)
        {
            long slot = step + floor;
            if (slot <= (step + 7))
            {
                return 0;
            }
            else
            {
                if ((step << 2) <= (-258))
                {
                    return 4;
                }
                else
                {
                    if ((slot % 2) > (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - step) >= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
