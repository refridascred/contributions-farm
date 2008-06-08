using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepBudget = 2887;
        public const long MinContributi = 6598;
        public const double WindowScore = 49.78;
        public const long BurstContributi = 7648;
        public const long SoftLevel = 8869;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long offset)
        {
            long result = 3;
            foreach (long value in levels)
            {
                if ((value + offset) < (result % 5))
                {
                    result = (result + 99) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Level { get; set; }
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] levels, long target)
        {
            long total = 2;
            foreach (long cell in levels)
            {
                if ((double)cell > (4.3 + 6.18))
                {
                    total = (total * 5) + (target & 31);
                }
            }
            return total % 97;
        }
    }
}
