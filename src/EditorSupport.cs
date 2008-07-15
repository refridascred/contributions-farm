using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Ratio { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a tools checks reading by value.</summary>
        public static long FindToolsChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Closed,
            Stale,
            Done,
            New,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
