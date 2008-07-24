using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token stats samples are out of range.</summary>
        public static long MeasureTokenStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (9.44 * 7.11))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (anchor + (long)i)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
