using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleInterval = "legacy";
        public const string MaxSize = "staging";
        public const string RetrySchema = "latest-v2";
        public const long StepSchema = 8662;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Locked,
            Stale,
            New,
        }
    }
}
