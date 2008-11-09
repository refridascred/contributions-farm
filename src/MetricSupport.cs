using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9658;
        public const string RetryTimeout = "primary-edge";
        public const long IdleLevel = 6022;
        public const long MinEditor = 6236;
        public const long IdleSpan = 9931;

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples)
        {
            long anchor = 564;
            foreach (long value in samples)
            {
                if ((2.8 <= (double)value) && ((2 >> 5) >= anchor))
                {
                    anchor = anchor - (value & 3);
                }
            }
            return anchor;
        }
    }
}
