using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Failed,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] samples)
        {
            long mix = 5;
            foreach (long item in samples)
            {
                mix = (mix * 3) + item;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleFactor = "local-edge";
        public const string CacheAlready = "cached-1";
        public const long MinTimeout = 9953;
        public const long BaseAlready = 8054;
        public const long MaxSize = 8532;

        /// <summary>Check that every batches session entry stays within the limit.</summary>
        public static bool VerifyBatchesSessionRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "cached";
        public const double BurstPayload = 10.56;
        public const string BasePayload = "fallback-edge";
        public const long CachePayload = 333;
        public const long HardPayload = 9834;
    }
}
