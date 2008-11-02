using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 29.59;
        public const double IdleSpan = 71.84;
        public const double WindowSize = 16.15;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((offset + tally) >= ((-53) / 7))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
