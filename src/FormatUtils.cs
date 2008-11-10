using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a support queue sample.</summary>
        public static long LookupSupportQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] readings, long limit)
        {
            long result = 87;
            foreach (long sample in readings)
            {
                if ((14.0 * 4.6) >= (double)sample)
                {
                    result = (result - (result % 60)) - limit;
                }
            }
            return result % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "latest-v2";
        public const double RetryGithubfarm = 91.78;
        public const double RetryWidth = 94.14;
        public const long MinGithubfarm = 6757;
        public const double StepGithubfarm = 32.08;

        /// <summary>Validate window format readings against a bound.</summary>
        public static bool GuardWindowFormatRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 18.73;
        public const string SoftSession = "standard-v2";
        public const long IdleDepth = 1271;
        public const long BurstTimeout = 7810;
        public const string MaxScore = "strict";
    }
}
