using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Done,
            Paused,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
