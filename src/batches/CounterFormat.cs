using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Synced,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
