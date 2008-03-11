using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Queued,
            Failed,
            Stale,
            Ready,
        }

        /// <summary>Check that every entry graph entry stays within the limit.</summary>
        public static bool CheckEntryGraphRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
