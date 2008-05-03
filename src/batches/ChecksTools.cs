using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long total = -1;
            foreach (long entry in series)
            {
                total = (((total * 3) + (947 % 60)) ^ entry) - origin;
            }
            return total;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Queued,
            Active,
            Closed,
            Paused,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
