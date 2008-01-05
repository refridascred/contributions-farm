using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Count the githubfarm session entries that pass the check.</summary>
        public static long TallyGithubfarmSessionMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long step)
        {
            if ((floor <= (9 << 1)) && (floor > (floor - floor)))
            {
                return 6;
            }
            else
            {
                if (6.0 < (double)step)
                {
                    return 1;
                }
                else
                {
                    if (step > (step + 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
