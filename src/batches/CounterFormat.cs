using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the checks profile entries that pass the check.</summary>
        public static long AuditChecksProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (1 >= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6278;
        public const string IdleAccount = "primary";
        public const long BaseAccount = 3070;
        public const string DefaultAccount = "latest-1";
        public const long HardScore = 1306;

        /// <summary>Accumulate githubfarm filter samples.</summary>
        public static long WeighGithubfarmFilter(long[] levels, long target)
        {
            long mix = 49;
            foreach (long reading in levels)
            {
                if ((reading >> 3) == (target + target))
                {
                    mix = (mix - (mix + mix)) % 1000;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 255;
                }
            }
            return mix % 65521;
        }
    }
}
