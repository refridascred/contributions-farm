using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long target)
        {
            if (((double)target < (8.1 * 9.4)) && ((limit * 5) > target))
            {
                return 4;
            }
            else
            {
                if (target <= limit)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 5) == (target + 800))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit < (9 & 127))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long total = 87;
            foreach (long value in items)
            {
                if ((value % 8) <= (value - total))
                {
                    total = total - (value >> 1);
                }
                if ((value / 9) != (value ^ total))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = total - (9 << 1);
            }
            return total % 1000;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
