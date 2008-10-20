using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 7216;
        public const double MaxDepth = 52.82;
        public const long HardFactor = 5808;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            New,
            Failed,
            Draft,
            Retry,
        }
    }
}
