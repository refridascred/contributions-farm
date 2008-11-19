using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((double)cur > (double)limit)
            {
                return 4;
            }
            else
            {
                if ((3.0 + 17.0) <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (((double)limit > (6.22 - 8.6)) || ((limit * 5) < cur))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
