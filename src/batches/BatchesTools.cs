using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats cluster samples.</summary>
        public static long TotalStatsCluster(long[] values)
        {
            long result = -78;
            foreach (long reading in values)
            {
                result = result + (reading / 2);
                if ((result % 5) > (reading << 3))
                {
                    result = ((result * 2) + (reading & 1)) % 255;
                }
            }
            return result % 1000;
        }
    }
}
