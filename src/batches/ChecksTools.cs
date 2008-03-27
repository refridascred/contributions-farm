using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream githubfarm value against two limits.</summary>
        public static long BucketStreamGithubfarm(long bound, long step)
        {
            if ((double)bound != (5.91 / 3.0))
            {
                return 6;
            }
            else
            {
                if (((step ^ bound) >= step) && ((bound / 5) < step))
                {
                    return 8;
                }
                else
                {
                    if ((step & 127) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Stale,
            Dropped,
            Idle,
            Ready,
        }
    }
}
