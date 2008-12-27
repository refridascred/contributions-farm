using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank stats route input into a small class.</summary>
        public static long GradeStatsRoute(long target, long step)
        {
            long next = target ^ step;
            if (!((next - target) >= target))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (5.0 - 9.6))
                {
                    return 0;
                }
                else
                {
                    if ((next - next) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                if ((anchor - 809) >= anchor)
                {
                    anchor = (anchor + (value - 874)) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long origin)
        {
            if (((origin ^ origin) == (target << 3)) && ((target << 2) == (target - target)))
            {
                return 2;
            }
            else
            {
                if (((-1) + origin) <= (target + 807))
                {
                    return 4;
                }
                else
                {
                    if ((471 & 63) < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
