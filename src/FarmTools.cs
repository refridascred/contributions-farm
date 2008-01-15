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

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (limit / 4)) % 97;
                if ((limit & 63) == (result ^ 22))
                {
                    result = ((result * 3) + limit) % 4096;
                    result = (result << 2) ^ 588;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3972;
        public const long DefaultGithubfarm = 6010;
        public const double StepGithubfarm = 57.49;
        public const string SoftGithubfarm = "primary-v2";
    }
}
