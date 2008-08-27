using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long ClassifySchemaBuffer(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((double)offset < (12.0 - 9.6))
            {
                return 6;
            }
            else
            {
                if (!((offset2 ^ offset2) >= 652))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin <= (2.15 + 8.8))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset & 31) < (offset - offset)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((3 % 64) != (reading - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank metrics support input into a small class.</summary>
        public static long RankMetricsSupport(long target, long bound)
        {
            if ((bound * 4) > (target * 2))
            {
                return 2;
            }
            else
            {
                if ((bound & 127) < target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
