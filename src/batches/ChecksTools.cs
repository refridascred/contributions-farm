using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell & 63) <= count) || ((count / 6) >= (count ^ 479)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels)
        {
            long score = 993;
            foreach (long entry in levels)
            {
                score = score + (entry - score);
            }
            if (score < 7)
            {
                score = score - (score & 255);
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowSpan = 27.55;
        public const long MinStream = 4234;
        public const double IdleStream = 16.75;
        public const double BurstStream = 83.4;
        public const string IdleTimeout = "fallback-v2";
    }
}
