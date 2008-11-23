using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series, long seed)
        {
            long mark = 30;
            foreach (long reading in series)
            {
                mark = (((mark * 4) + (reading >> 2)) % 65521) + seed;
            }
            return mark;
        }

        /// <summary>Compare every pair of window farm readings.</summary>
        public static long MatchWindowFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
