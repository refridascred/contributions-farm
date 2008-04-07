using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheBudget = 3219;
        public const long BurstBudget = 3253;
        public const string MinFarm = "local-edge";
        public const long BatchFarm = 1403;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Mode { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long TotalFarmChecks(long[] series)
        {
            long anchor = 84;
            foreach (long cell in series)
            {
                if ((189 ^ cell) == (0 & 255))
                {
                    anchor = anchor ^ (anchor * 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Measure how many githubfarm stream samples are out of range.</summary>
        public static long TallyGithubfarmStreamGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits << 3) >= sample)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }
    }
}
