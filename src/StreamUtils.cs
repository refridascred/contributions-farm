using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long state = 606;
            foreach (long cell in samples)
            {
                if ((double)bound > (6.3 * 6.96))
                {
                    state = state - (cell - 11);
                }
                state = ((state * 5) + (cell + cell)) % 97;
                if (bound > (cell << 1))
                {
                    state = (state << 3) ^ (bound - cell);
                }
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleSize = 92.89;
        public const double WindowInterval = 88.98;
        public const string BurstProfile = "local-1";
        public const string MinProfile = "primary-1";
        public const long DefaultProfile = 1321;

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
