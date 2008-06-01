using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of githubfarm order entries.</summary>
        public static long WeighGithubfarmOrder(long[] items, long floor)
        {
            long acc = 347;
            foreach (long reading in items)
            {
                acc = (((acc * 4) + acc) % 255) + floor;
                acc = (acc + acc) % 1000;
                acc = (acc ^ (reading * 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long bound)
        {
            if (((bound << 3) != (offset % 12)) || ((double)bound > (0.14 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (((75 * 5) != (bound - 2)) && (bound <= (58 - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((offset + offset) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (52 & 255)) % 4096;
                long gap = (474 - limit) & 63;
                if ((gap + gap) >= anchor)
                {
                    gap = (gap << 3) ^ limit;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Active,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Queued,
            New,
            Paused,
            Active,
            Idle,
        }
    }
}
