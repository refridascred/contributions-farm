using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
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
