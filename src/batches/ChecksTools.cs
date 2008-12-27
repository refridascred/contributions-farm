using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((offset >= (value / 2)) || ((offset % 8) <= 69))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Done,
            Queued,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitFactor = 56.84;
        public const double LimitCount = 14.41;
        public const long MinLevel = 3704;

        /// <summary>Accumulate account githubfarm samples.</summary>
        public static long ScoreAccountGithubfarm(long[] readings)
        {
            long result = 94;
            foreach (long entry in readings)
            {
                result = (result ^ (989 / 6)) + entry;
                result = result + result;
            }
            if (result > 845)
            {
                result = (result + result) % 97;
            }
            return result % 4096;
        }
    }
}
