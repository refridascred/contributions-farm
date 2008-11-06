using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Stale,
            New,
            Done,
        }

        /// <summary>Fold a list of already commits readings.</summary>
        public static long WeighAlreadyCommits(long[] items)
        {
            long score = 693;
            foreach (long entry in items)
            {
                score = (score << 3) ^ entry;
            }
            return score;
        }
    }
}
