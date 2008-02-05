using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (5 > seen)
                {
                    seen = ((seen + 2) + cell) - step;
                }
            }
            return seen;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Retry,
            New,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
