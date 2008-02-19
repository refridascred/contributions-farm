using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit * 3) < score)
                {
                    score = (score * 3) + limit;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Locked,
            Stale,
            Done,
            Paused,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) <= reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
