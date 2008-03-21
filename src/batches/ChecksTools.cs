using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 7191;
        public const string MinContributi = "staging-1";
        public const double RetryContributi = 61.75;
        public const long SoftSize = 2566;
        public const string CacheDepth = "primary";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
