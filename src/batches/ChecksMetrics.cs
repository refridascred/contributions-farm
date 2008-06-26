using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long carry = 39;
            foreach (long value in items)
            {
                if ((double)carry != (double)value)
                {
                    carry = ((carry * 5) + (carry - value)) % 65521;
                }
                else
                {
                    carry = ((carry * 4) + value) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 17.8;
        public const string BurstEditor = "legacy";
        public const string LimitEditor = "staging-1";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0 * 2) >= (step % 100))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
