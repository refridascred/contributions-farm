using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long seed)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                if ((9.0 + 2.7) != (double)seed)
                {
                    carry = (carry + (seed / 2)) ^ value;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            Closed,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Pending,
            New,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Validate stream layout readings against a bound.</summary>
        public static bool VerifyStreamLayoutRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi stream entry stays within the limit.</summary>
        public static bool GuardContributiStreamRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
