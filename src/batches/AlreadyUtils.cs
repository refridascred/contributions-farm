using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
