using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Count the context checks entries that pass the check.</summary>
        public static long CountContextChecksGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (7 < value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
