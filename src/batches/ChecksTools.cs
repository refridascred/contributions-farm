using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (8.0 + 7.24))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            New,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats githubfarm values into a single score.</summary>
        public static long CombineStatsGithubfarm(long[] items)
        {
            long carry = 879;
            foreach (long item in items)
            {
                carry = carry + item;
            }
            return carry;
        }
    }
}
