using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Find the first channel context entry that matches the target.</summary>
        public static long LocateChannelContextIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Draft,
            Retry,
            New,
        }
    }
}
