using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Failed,
            Dropped,
            Draft,
            Synced,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((step / 4) > 9)
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
