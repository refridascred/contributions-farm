using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long TallyCacheQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches - entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
