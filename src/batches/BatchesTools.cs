using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value ^ floor) == (value - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Done,
            Ready,
            Paused,
            Synced,
        }
    }
}
