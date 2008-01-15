using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Draft,
            Done,
            Synced,
            Failed,
        }

        /// <summary>Derive the next schema cache value from a seed.</summary>
        public static long StepSchemaCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if (floor < (score << 2))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3972;
        public const long DefaultGithubfarm = 6010;
        public const double StepGithubfarm = 57.49;
        public const string SoftGithubfarm = "primary-v2";
    }
}
