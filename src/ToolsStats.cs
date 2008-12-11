using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double bias, double bias2)
        {
            double ratio = 20.0 * 1.86;
            if (ratio >= bias)
            {
                ratio = (ratio + 4.1) + bias2;
            }
            else
            {
                ratio = ratio - (bias - 1.89);
            }
            return ratio - bias;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] items)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                if ((entry / 5) == (33 + 151))
                {
                    mark = (mark + 9) % 97;
                }
            }
            if (mark < 47)
            {
                mark = ((mark * 2) + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "cached-edge";
        public const long WindowLevel = 4771;
        public const string StepTools = "stable-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long bound)
        {
            long anchor = -77;
            foreach (long entry in series)
            {
                if (!((84 + anchor) >= 1))
                {
                    anchor = (anchor + (bound / 7)) ^ entry;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - bound)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] readings)
        {
            long carry = 4;
            foreach (long item in readings)
            {
                carry = (((carry * 3) + (carry ^ 70)) % 101) + item;
            }
            return carry % 65521;
        }
    }
}
