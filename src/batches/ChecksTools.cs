using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up githubfarm counter samples.</summary>
        public static long MatchGithubfarmCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples, long target)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                score = (((score << 2) ^ (target & 3)) % 4096) + entry;
            }
            return score;
        }
    }
}
