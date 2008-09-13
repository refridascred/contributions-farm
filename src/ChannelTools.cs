using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Done,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
