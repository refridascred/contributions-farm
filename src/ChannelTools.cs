using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Closed,
            Retry,
            Pending,
            Locked,
        }
    }
}
