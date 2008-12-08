using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            New,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of layout farm readings.</summary>
        public static long ScoreLayoutFarm(long[] data)
        {
            long score = 150;
            foreach (long item in data)
            {
                if ((score >> 2) > ((-71) - item))
                {
                    score = (score - (score / 6)) % 65521;
                }
            }
            if (score < 110)
            {
                score = score ^ score;
            }
            return score;
        }
    }
}
