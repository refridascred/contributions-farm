using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long limit, long origin)
        {
            if ((limit * 5) < 95)
            {
                return 6;
            }
            else
            {
                if (((double)origin > (double)18) || (14.0 >= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((10.0 + 2.5) > (6.07 + 20.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Dropped,
            Done,
            Synced,
            Stale,
        }
    }
}
