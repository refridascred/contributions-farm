using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseDepth = 610;
        public const double BaseAccount = 22.2;
        public const long HardCount = 8322;
        public const long HardLevel = 483;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
