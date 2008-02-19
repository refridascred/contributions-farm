using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Ready,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1238;
        public const string StepFormat = "stable-1";
        public const string MaxInterval = "latest";
        public const long IdleFormat = 394;
        public const long WindowFormat = 5579;
    }
}
