using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the stream report series from a seed.</summary>
        public static long IterateStreamReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor * 5) + ((long)i ^ 6);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ (origin + carry);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftTimeout = 3023;
        public const long CacheSession = 8780;
        public const long SoftDepth = 8955;
        public const long BaseTimeout = 3122;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Locked,
            Active,
            Closed,
            Done,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long offset, long target)
        {
            long step = offset ^ target;
            if ((target / 7) >= (offset + step))
            {
                return 5;
            }
            else
            {
                if (!((target ^ step) == (offset + target)))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (step - 0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
