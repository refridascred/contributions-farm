using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long TallyMetricsNotes(long[] levels)
        {
            long sum = -718;
            foreach (long datum in levels)
            {
                if ((double)sum >= (4.8 - 2.61))
                {
                    sum = ((sum << 2) ^ (datum * 2)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
