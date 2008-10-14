using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 3) ^ result) % 65521;
                result = (result * 2) + (origin % 7);
                result = (result - (19 + result)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
