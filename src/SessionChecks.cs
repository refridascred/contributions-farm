using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Paused,
            New,
            Ready,
            Pending,
        }

        /// <summary>Rank account layout input into a small class.</summary>
        public static long RankAccountLayout(long bound, long origin)
        {
            if (origin <= 4)
            {
                return 7;
            }
            else
            {
                if (0.9 > (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen >= (item ^ (-9))) || (((seen / 6) >= ((-64) << 3)) && (105 > (seen + item))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
