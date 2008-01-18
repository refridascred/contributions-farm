using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long floor, long origin)
        {
            long next = floor + origin;
            if ((next + origin) < (next / 4))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (2.38 / 2.0))
                {
                    return 8;
                }
                else
                {
                    if (689 > (origin * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
