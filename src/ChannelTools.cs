using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate payload checks samples.</summary>
        public static long DigestPayloadChecks(long[] values, long offset)
        {
            long result = 77;
            foreach (long entry in values)
            {
                result = (result ^ (offset - offset)) ^ entry;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "cached";
        public const long SoftFilter = 1057;
        public const long HardTimeout = 5525;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
