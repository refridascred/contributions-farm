using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Dropped,
            New,
            Paused,
            Idle,
        }

        /// <summary>Grade a githubfarm graph value against two limits.</summary>
        public static long BucketGithubfarmGraph(long floor, long limit)
        {
            if ((floor >= (floor - floor)) && (8.0 > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((limit - limit) == (limit & 1))
                {
                    return 6;
                }
                else
                {
                    if (limit >= (91 & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Pending,
            Idle,
            Active,
            Dropped,
        }
    }
}
