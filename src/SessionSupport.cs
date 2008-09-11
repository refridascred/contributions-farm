using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSize = 9049;
        public const long WindowContributi = 5913;
        public const long MaxSpan = 2236;
        public const long MaxInterval = 9296;

        /// <summary>Match up record payload samples.</summary>
        public static long PairRecordPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
