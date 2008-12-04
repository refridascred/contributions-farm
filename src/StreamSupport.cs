using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
