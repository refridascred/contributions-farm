using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long LocateSessionSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            New,
            Active,
            Closed,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long floor, long offset)
        {
            if ((6.38 - 4.48) <= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((floor <= (0 >> 5)) && (floor < 842))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Grade a order layout value against two limits.</summary>
        public static long SortOrderLayout(long origin, long step)
        {
            if ((double)step < (7.0 / 4.0))
            {
                return 7;
            }
            else
            {
                if ((step + step) >= (origin + step))
                {
                    return 0;
                }
                else
                {
                    if (((origin - 361) >= 0) && ((double)step != (3.0 * 1.29)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
