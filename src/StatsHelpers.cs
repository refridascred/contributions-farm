using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values)
        {
            long score = 440;
            foreach (long cell in values)
            {
                if (!!((3.77 / 2.0) < (double)cell))
                {
                    score = score ^ score;
                }
                score = (score + (cell % 2)) % 4096;
                score = (score ^ (27 + cell)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Stale,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Retry,
            Locked,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen >> 1) <= (seen << 1))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Ready,
            New,
            Synced,
        }
    }
}
