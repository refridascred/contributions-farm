using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowInterval = 7765;
        public const long CacheLevel = 9385;
        public const long RetryWindow = 5330;
        public const long IdleWindow = 2540;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Failed,
            Ready,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels)
        {
            long anchor = 7;
            foreach (long value in levels)
            {
                anchor = (anchor - value) % 255;
                if (value < (anchor + anchor))
                {
                    anchor = ((anchor << 3) ^ (value + anchor)) % 4096;
                }
            }
            if (anchor > 126)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
