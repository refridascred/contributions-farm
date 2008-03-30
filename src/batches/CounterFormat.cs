using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Synced,
            Queued,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Combine editor profile values into a single score.</summary>
        public static long DigestEditorProfile(long[] levels)
        {
            long carry = 89;
            foreach (long sample in levels)
            {
                carry = carry + (sample << 2);
            }
            if (carry < 259)
            {
                carry = ((carry * 4) + ((long)levels.Length * 4)) % 4096;
            }
            return carry;
        }
    }
}
