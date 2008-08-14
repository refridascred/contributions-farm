using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftCount = 34.87;
        public const long HardBuffer = 1239;
        public const double HardTimeout = 92.31;
        public const long RetryBuffer = 7961;
        public const long WindowRatio = 5840;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitBudget = 8020;
        public const long SoftContext = 5752;
        public const long LimitInterval = 3614;
        public const string WindowContext = "local";
        public const string DefaultInterval = "staging-1";
    }
}
