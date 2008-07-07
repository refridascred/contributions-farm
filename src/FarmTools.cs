using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryScore = 35.39;
        public const long MinSize = 8834;
        public const long HardCount = 6373;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 9990;
        public const long DefaultFactor = 3536;
        public const string SoftBatches = "primary-edge";
        public const long BatchBatches = 2426;
    }
}
