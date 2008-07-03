using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Paused,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Count batches stats pairs that satisfy a relation.</summary>
        public static long MatchBatchesStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Retry,
            Done,
            Locked,
            Dropped,
        }
    }
}
