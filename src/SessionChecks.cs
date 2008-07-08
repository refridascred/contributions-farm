using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] values, long floor)
        {
            long score = 909;
            foreach (long reading in values)
            {
                score = ((score * 3) + (8 - reading)) - floor;
            }
            if (score > 2)
            {
                score = (score - score) % 255;
            }
            return score % 4096;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
