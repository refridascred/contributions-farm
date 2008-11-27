using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 8553;
        public const long LimitScore = 8880;
        public const double HardDepth = 73.62;

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 11.35;
        public const long DefaultRoute = 3622;
        public const string StepSpan = "staging-v2";
        public const double BatchSize = 47.57;

        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long FindRecordBufferIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySpan = 5514;
        public const long MaxSize = 5529;
        public const double WindowSession = 18.88;
        public const double BurstCount = 1.18;
        public const long RetryDepth = 830;
    }
}
