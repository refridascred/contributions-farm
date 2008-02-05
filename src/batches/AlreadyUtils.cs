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

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Locked,
            Dropped,
        }

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
