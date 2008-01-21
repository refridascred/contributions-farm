using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Queued,
            Locked,
            Paused,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
