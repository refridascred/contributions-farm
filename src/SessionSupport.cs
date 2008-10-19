using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((double)tally < (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 264;
            foreach (long sample in series)
            {
                if (!((score ^ score) != (score - score)))
                {
                    score = (score ^ (score + 10)) ^ sample;
                }
            }
            if (score < (-15))
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Synced,
            New,
            Ready,
            Active,
        }
    }
}
