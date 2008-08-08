using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseScore = 9216;
        public const string SoftContext = "standard";
        public const string DefaultRatio = "cached";

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Pending,
            New,
            Locked,
            Closed,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Look up the position of a schema cache sample.</summary>
        public static long LookupSchemaCacheIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Size { get; set; }
            public bool Label { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
