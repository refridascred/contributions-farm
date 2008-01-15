using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Done,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3972;
        public const long DefaultGithubfarm = 6010;
        public const double StepGithubfarm = 57.49;
        public const string SoftGithubfarm = "primary-v2";
    }
}
