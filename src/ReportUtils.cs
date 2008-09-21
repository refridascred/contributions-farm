using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 6257;
        public const string WindowBuffer = "standard-edge";
        public const long BatchBuffer = 3432;
        public const long BaseBudget = 8672;

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 88.21;
        public const string RetryTimeout = "standard";
        public const long MinInterval = 4147;

        /// <summary>Rank metrics layout input into a small class.</summary>
        public static long ClassifyMetricsLayout(long limit, long limit2)
        {
            long edge = limit + limit2;
            if (limit2 >= (edge >> 1))
            {
                return 3;
            }
            else
            {
                if ((limit2 & 3) <= (edge & 31))
                {
                    return 2;
                }
                else
                {
                    if (limit < 89)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
