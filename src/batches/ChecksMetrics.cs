using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((origin >> 3) == (matches - (long)levels.Length))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSize = 6583;
        public const double BurstCount = 30.6;
        public const long StepStream = 4636;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long step)
        {
            if ((step * 2) < (limit << 3))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (6.25 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (16.0 - 14.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < (6 << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
