using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a entry support sample.</summary>
        public static long LocateEntrySupportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Synced,
            New,
            Ready,
            Closed,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Paused,
            Synced,
        }
    }
}
