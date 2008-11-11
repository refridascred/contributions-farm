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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheFactor = 1539;
        public const double SoftLevel = 84.45;
        public const long SoftTimeout = 6367;
        public const long StepRecord = 3322;
        public const double StepSpan = 89.13;

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
