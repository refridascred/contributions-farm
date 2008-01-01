using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2348;
        public const double RetryCount = 29.81;
        public const string DefaultGithubfarm = "cached";
        public const long WindowSize = 6818;
        public const double BaseGithubfarm = 97.55;

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 8838;
        public const double RetryBatch = 9.86;
        public const long StepSize = 7011;
        public const double BaseBatch = 91.91;
        public const double BatchBudget = 24.41;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] readings)
        {
            long total = 8;
            foreach (long datum in readings)
            {
                if ((total >= datum) || ((double)total > (2.31 * 18.0)))
                {
                    total = (total << 2) ^ 7;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
