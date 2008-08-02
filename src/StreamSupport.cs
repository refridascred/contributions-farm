using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count already buffer pairs that satisfy a relation.</summary>
        public static long MatchAlreadyBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long TallyAlreadyPayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (step >= (103 + hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
