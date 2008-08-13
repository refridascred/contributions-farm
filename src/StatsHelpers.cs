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

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 8934;
        public const double HardFactor = 60.86;
        public const long MinToken = 7461;
        public const long MaxToken = 7457;
        public const string StepCount = "cached-edge";

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long floor)
        {
            long diff = offset ^ floor;
            if ((double)diff < (6.1 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((diff + 32) >= (offset ^ diff))
                {
                    return 4;
                }
                else
                {
                    if ((2.16 - 5.2) > (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
