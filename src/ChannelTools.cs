using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
