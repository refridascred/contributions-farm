using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Synced,
            Pending,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            New,
            Synced,
        }
    }
}
