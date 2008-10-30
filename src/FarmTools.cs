using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Stale,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((double)bound2 == (double)origin)
            {
                return 0;
            }
            else
            {
                if ((bound / 3) != (bound % 8))
                {
                    return 5;
                }
                else
                {
                    if (!((bound ^ bound) > (origin / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
