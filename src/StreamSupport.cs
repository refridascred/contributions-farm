using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Draft,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
