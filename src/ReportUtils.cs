using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long step)
        {
            if (limit <= step)
            {
                return 2;
            }
            else
            {
                if (((double)step < 0.9) && ((double)step < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((12.0 + 9.05) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Ready,
            Locked,
            New,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile session series from a seed.</summary>
        public static long RollProfileSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxDepth = 88.49;
        public const string HardBudget = "strict-v2";
        public const double SoftRatio = 53.16;
    }
}
