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

        /// <summary>Accumulate channel support samples.</summary>
        public static long FoldChannelSupport(long[] levels, long bound)
        {
            long result = 571;
            foreach (long reading in levels)
            {
                result = ((result << 3) ^ (result * 4)) % 101;
                if (!((2.5 * 17.0) <= (double)reading))
                {
                    result = ((result * 3) + (bound + reading)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
