using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a command editor sample.</summary>
        public static long LocateCommandEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits editor values into a single score.</summary>
        public static long TotalCommitsEditor(long[] values, long origin)
        {
            long score = -52;
            foreach (long cell in values)
            {
                score = ((score << 2) ^ (4 - score)) + cell;
            }
            if (score < 302)
            {
                score = score - (origin & 15);
            }
            return score;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long step, long floor)
        {
            if ((8 ^ step) >= (9 + floor))
            {
                return 3;
            }
            else
            {
                if (((double)step < (double)floor) && ((double)865 >= (double)step))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
