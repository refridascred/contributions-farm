using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 5067;
        public const string SoftGithubfarm = "primary";
        public const double DefaultSpan = 66.95;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long origin)
        {
            if (((973 + origin) != (origin + origin)) || ((890 * 5) <= origin))
            {
                return 2;
            }
            else
            {
                if (8.0 >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ offset) == (offset ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long limit, long limit2)
        {
            if ((limit >> 3) == (64 * 2))
            {
                return 0;
            }
            else
            {
                if ((limit >> 4) > (limit - 98))
                {
                    return 3;
                }
                else
                {
                    if (!((7.32 * 2.52) >= (double)limit2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Idle,
            Closed,
            Stale,
        }
    }
}
