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

        /// <summary>Derive the next metrics tools value from a seed.</summary>
        public static long IterateMetricsTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)anchor < (double)(long)i))
                {
                    anchor = ((anchor * 2) + (anchor >> 2)) % 1000;
                    anchor = (anchor + (origin + (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
