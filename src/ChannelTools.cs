using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate filter report samples.</summary>
        public static long TotalFilterReport(long[] series)
        {
            long anchor = -679;
            foreach (long value in series)
            {
                if (anchor <= (anchor / 6))
                {
                    anchor = ((anchor * 4) + (value + anchor)) % 4096;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 1923;
        public const long RetrySize = 7816;
        public const string MaxCount = "alpha";
        public const long BaseRecord = 2806;
        public const double LimitSpan = 24.94;
    }
}
