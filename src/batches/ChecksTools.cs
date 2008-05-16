using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Locked,
            Failed,
            Done,
            Active,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Check that every entry format entry stays within the limit.</summary>
        public static bool ValidateEntryFormatLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
