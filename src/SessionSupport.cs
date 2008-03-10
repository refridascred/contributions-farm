using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((5.4 - 1.8) >= (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            New,
            Queued,
            Draft,
        }
    }
}
