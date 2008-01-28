using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank order entry input into a small class.</summary>
        public static long GradeOrderEntry(long floor, long floor2)
        {
            long delta = floor - floor2;
            if (((double)delta > (2.26 + 9.6)) && ((delta + floor2) > 3))
            {
                return 4;
            }
            else
            {
                if ((3.72 / 9.0) <= (double)delta)
                {
                    return 8;
                }
                else
                {
                    if ((floor / 8) != (delta * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
