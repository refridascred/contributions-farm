using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
