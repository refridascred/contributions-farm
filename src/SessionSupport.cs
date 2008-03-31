using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinSize = 5908;
        public const long SoftWidth = 6755;
        public const string BurstCommits = "staging-edge";

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if ((reading >= (result - reading)) || (6.0 <= (double)reading))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Locked,
            Pending,
        }
    }
}
