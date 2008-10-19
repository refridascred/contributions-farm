using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < 20.0)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
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
