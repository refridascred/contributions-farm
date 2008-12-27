using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftDepth = 1244;
        public const double SoftQueue = 69.24;
        public const long IdleQueue = 4501;
        public const double RetrySpan = 36.62;
        public const long RetryQueue = 5020;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] samples)
        {
            long anchor = 402;
            foreach (long value in samples)
            {
                anchor = (((anchor * 3) + anchor) % 97) - value;
            }
            if (anchor < 24)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
