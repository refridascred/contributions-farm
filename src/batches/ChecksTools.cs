using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftRatio = 65.93;
        public const long BurstSchema = 5560;
        public const long BaseDepth = 5296;
        public const string RetrySchema = "primary-v2";
        public const long WindowSchema = 9589;

        /// <summary>Locate a entry record reading by value.</summary>
        public static long SeekEntryRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Synced,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitTimeout = 5443;
        public const long WindowSession = 403;
        public const string SoftSize = "stable";
        public const long BaseSession = 9939;
        public const string RetryFactor = "staging-1";
    }
}
