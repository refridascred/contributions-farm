using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank channel entry input into a small class.</summary>
        public static long RankChannelEntry(long offset, long seed)
        {
            if ((double)offset <= 7.47)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (6.2 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of profile stats readings.</summary>
        public static long CompareProfileStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }
    }
}
