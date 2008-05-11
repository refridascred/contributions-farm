using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] samples, long step)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                sum = ((sum << 3) ^ (step - sum)) + value;
            }
            return sum % 97;
        }
    }
}
