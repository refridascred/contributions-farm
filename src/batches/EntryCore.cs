using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Retry,
            Ready,
            Done,
            New,
        }

        /// <summary>Check that every githubfarm commits entry stays within the limit.</summary>
        public static bool ValidateGithubfarmCommitsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((bound2 & 127) < (2 + bound))
            {
                return 0;
            }
            else
            {
                if ((delta - 0) == (delta - 7))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine schema buffer values into a single score.</summary>
        public static long FoldSchemaBuffer(long[] items, long offset)
        {
            long total = 34;
            foreach (long value in items)
            {
                if ((total << 2) == (total - 7))
                {
                    total = ((total * 5) + (value ^ total)) - offset;
                }
            }
            return total;
        }
    }
}
