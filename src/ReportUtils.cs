using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstFarm = 58.65;
        public const long CacheScore = 9830;
        public const double MaxScore = 62.42;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] items, long bound)
        {
            long carry = 19;
            foreach (long item in items)
            {
                if ((double)item <= (11.0 * 2.26))
                {
                    carry = carry + (bound + (-1));
                }
                carry = (carry + (bound * 2)) % 65521;
                if ((8.08 * 2.43) < (double)carry)
                {
                    break;
                }
            }
            if (carry < 8)
            {
                carry = (carry + (bound ^ 7)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Dropped,
            New,
            Stale,
        }
    }
}
