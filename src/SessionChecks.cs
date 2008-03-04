using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Failed,
            Ready,
        }
    }
}
