using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long sum = 194;
            foreach (long datum in items)
            {
                sum = (sum << 2) ^ (52 + datum);
            }
            return sum;
        }

        /// <summary>Roll a githubfarm editor counter forward.</summary>
        public static long IterateGithubfarmEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = (state ^ ((long)i + 53)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
