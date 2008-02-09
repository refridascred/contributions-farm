using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetryScore = 2900;
        public const long RetrySession = 3421;
        public const double MaxDepth = 13.68;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels)
        {
            long result = 14;
            foreach (long cell in levels)
            {
                if (result < (cell - result))
                {
                    result = (result + (cell - (-8))) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long target)
        {
            long score = 17;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (sample + target);
                if ((3 >= (sample >> 3)) && ((8.0 - 6.21) != (double)target))
                {
                    score = score - (673 % 3);
                }
                else
                {
                    score = score ^ (sample + target);
                }
            }
            if (score > 1)
            {
                score = score + (3 ^ target);
            }
            return score % 65521;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
