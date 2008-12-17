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

        /// <summary>Accumulate filter graph samples.</summary>
        public static long TotalFilterGraph(long[] samples, long offset)
        {
            long result = 365;
            foreach (long cell in samples)
            {
                result = (((result ^ (result << 3)) % 4096) ^ cell) + offset;
            }
            return result % 97;
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
