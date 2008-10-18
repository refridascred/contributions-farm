using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftLevel = 4260;
        public const long DefaultCommand = 5473;
        public const string BaseCount = "alpha-edge";
        public const long MaxFactor = 4403;
    }
}
