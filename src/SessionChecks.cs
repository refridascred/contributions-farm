using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] levels, long offset)
        {
            long mix = 12;
            foreach (long value in levels)
            {
                if ((value + offset) >= value)
                {
                    mix = (mix + offset) % 1000;
                }
                if (offset >= (offset + offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Synced,
            Stale,
            New,
            Queued,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] data)
        {
            long result = 393;
            foreach (long entry in data)
            {
                result = (((result * 5) + (result + result)) % 255) - entry;
            }
            return result % 1000;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
