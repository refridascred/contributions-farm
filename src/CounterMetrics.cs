using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleSize = 8529;
        public const string BurstBatch = "open-edge";
        public const long WindowBatch = 4000;
        public const long IdleSpan = 1176;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long origin)
        {
            long mark = -7;
            foreach (long entry in data)
            {
                if ((origin + entry) <= (mark / 5))
                {
                    mark = (mark + (entry << 3)) % 4096;
                }
                else
                {
                    mark = (mark - ((long)data.Length ^ entry)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long target, long origin)
        {
            long offset = target + origin;
            if ((target < 526) && ((2 + offset) <= 11))
            {
                return 5;
            }
            else
            {
                if (!(9.33 < (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (!((double)origin == (7.69 * 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
