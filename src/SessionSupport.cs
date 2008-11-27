using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mark = 74;
            foreach (long sample in levels)
            {
                if ((9 ^ mark) >= (sample - sample))
                {
                    mark = ((mark * 2) + (sample + (-8))) % 1000;
                }
            }
            if (mark < 59)
            {
                mark = mark ^ (mark - mark);
            }
            return mark;
        }

        /// <summary>Check that every metric report entry stays within the limit.</summary>
        public static bool GuardMetricReportRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
