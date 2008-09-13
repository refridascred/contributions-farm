using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
