using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long offset, long target)
        {
            if ((4.0 * 6.76) > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((target < (offset - offset)) || ((double)target == (9.56 + 15.0)))
                {
                    return 6;
                }
                else
                {
                    if (((12.0 - 8.9) < (double)offset) && ((double)offset == (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset * 4) <= target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank tools batch input into a small class.</summary>
        public static long BucketToolsBatch(long floor, long step)
        {
            long cur = floor - step;
            if ((8.55 + 2.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((step ^ cur) < (7 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
