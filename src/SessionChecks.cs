using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            New,
            Paused,
            Ready,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((3.7 + 4.02) >= (double)value) && ((9 + 165) > (step % 12)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }
    }
}
