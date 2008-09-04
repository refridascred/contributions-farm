using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Retry,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 4711;
        public const long DefaultQueue = 7245;
        public const string BurstQueue = "strict-edge";
        public const long StepQueue = 5744;
        public const long BatchFactor = 4834;

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "stable-edge";
        public const long DefaultWidth = 7687;
        public const string IdleWidth = "strict";
        public const double RetryWidth = 0.3;
        public const long DefaultAlready = 1701;
    }
}
