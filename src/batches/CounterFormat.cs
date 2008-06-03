using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Locked,
            Stale,
            New,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
