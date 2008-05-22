using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a record filter sample.</summary>
        public static long LocateRecordFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSize = 83.19;
        public const long MaxSession = 3217;
        public const long DefaultSession = 2731;
        public const long SoftScore = 8587;
        public const string RetryWidth = "legacy";
    }
}
