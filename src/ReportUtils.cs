using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of already metric readings.</summary>
        public static long CompareAlreadyMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] data)
        {
            long total = 41;
            foreach (long value in data)
            {
                if ((7.0 / 2.0) == (double)total)
                {
                    total = ((total - (-6)) % 97) + value;
                }
            }
            if (total < 52)
            {
                total = (total + (total ^ total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepCount = 8404;
        public const long StepAlready = 7187;
        public const double MinFactor = 13.7;
        public const long LimitRatio = 3008;
        public const long LimitLevel = 1100;
    }
}
