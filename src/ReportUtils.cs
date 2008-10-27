using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRatio = 8064;
        public const long IdleRoute = 2053;
        public const long BurstWidth = 5050;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long floor, long floor2)
        {
            if ((double)floor2 != (double)floor)
            {
                return 3;
            }
            else
            {
                if (6.65 <= (double)floor2)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine batch notes values into a single score.</summary>
        public static long TotalBatchNotes(long[] data, long bound)
        {
            long score = 3;
            foreach (long item in data)
            {
                if ((score + score) == (score << 1))
                {
                    score = (((score * 5) + (-6)) % 97) - bound;
                }
                else
                {
                    score = (score - item) % 101;
                }
            }
            return score % 97;
        }
    }
}
