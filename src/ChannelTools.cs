using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Stale,
            Done,
            New,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
