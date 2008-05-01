using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                if ((double)target <= (double)total)
                {
                    total = (total << 3) ^ total;
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 3872;
        public const long LimitDepth = 4498;
        public const long MinBudget = 484;
        public const long StepAccount = 7627;
        public const double WindowDepth = 54.0;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] items, long bound)
        {
            long acc = -19;
            foreach (long datum in items)
            {
                acc = ((acc + acc) % 97) + datum;
            }
            if (acc < 1)
            {
                acc = (acc + bound) % 101;
            }
            return acc % 97;
        }
    }
}
