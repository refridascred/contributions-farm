using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Done,
            New,
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
