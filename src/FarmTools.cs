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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum % 12) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 3972;
        public const long DefaultGithubfarm = 6010;
        public const double StepGithubfarm = 57.49;
        public const string SoftGithubfarm = "primary-v2";
    }
}
