using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Queued,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long origin2)
        {
            if (origin2 < (origin2 << 3))
            {
                return 8;
            }
            else
            {
                if (((origin2 + origin2) != (origin + origin)) || ((double)63 >= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin2 < (15.0 - 9.0)) && ((-85) > (origin2 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + cell) < (cell * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
