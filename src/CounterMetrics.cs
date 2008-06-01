using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Check that every layout format entry stays within the limit.</summary>
        public static bool ValidateLayoutFormatRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
