using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long origin, long origin2)
        {
            long edge = origin + origin2;
            if ((20.0 * 5.35) == (double)origin2)
            {
                return 7;
            }
            else
            {
                if (((double)edge < (9.3 + 1.7)) || ((origin >> 4) < (81 - origin)))
                {
                    return 3;
                }
                else
                {
                    if (origin >= (origin << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long result = 751;
            foreach (long reading in items)
            {
                if ((10.0 + 2.18) == (double)result)
                {
                    result = (result - (reading ^ reading)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a session editor counter forward.</summary>
        public static long IterateSessionEditor(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor - (anchor << 2)) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
