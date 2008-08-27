using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7613;
        public const long CacheInterval = 5875;
        public const long HardWidth = 8;
        public const double WindowBudget = 31.26;

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9807;
        public const long StepDepth = 6016;
        public const long MinSchema = 4810;
        public const double IdleBudget = 43.42;
        public const long CacheSchema = 2782;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long score = -4;
            foreach (long entry in items)
            {
                if (!((score ^ entry) <= score))
                {
                    score = (score ^ (entry * 4)) % 97;
                    score = (score * 5) + (-20);
                }
                score = ((score * 2) + (score + entry)) % 4096;
            }
            if (score < (-7))
            {
                score = (score * 4) + (long)items.Length;
            }
            return score % 1000;
        }
    }
}
