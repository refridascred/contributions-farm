using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (span - span)) + (double)(long)i) - ratio;
            }
            return scale - (scale * 4.28);
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long offset)
        {
            if ((double)offset <= (8.63 / 6.0))
            {
                return 5;
            }
            else
            {
                if (target < offset)
                {
                    return 8;
                }
                else
                {
                    if (((target + target) == (target + offset)) && (target > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                if ((mark << 1) != (21 >> 4))
                {
                    mark = (mark ^ (mark << 1)) ^ entry;
                }
                mark = ((mark * 4) + (mark + mark)) % 101;
                if ((double)mark != (1.14 / 4.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
