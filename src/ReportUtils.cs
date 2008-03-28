using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score ^ bound) % 1000) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - (1 * 5);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((3.5 <= (double)sample) && ((sample + count) > (count + count))) || ((double)sample > (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
