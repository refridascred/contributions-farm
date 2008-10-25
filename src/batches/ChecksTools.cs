using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 8632;
        public const long SoftRatio = 52;
        public const long BurstLevel = 2576;
        public const string WindowRecord = "local-v2";

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
