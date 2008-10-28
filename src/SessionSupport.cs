using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "local-edge";
        public const long CacheFactor = 7477;
        public const string LimitScore = "latest-v2";
        public const long RetryBudget = 280;
    }
}
