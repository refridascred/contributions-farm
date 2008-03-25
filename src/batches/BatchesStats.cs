using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long limit)
        {
            if ((limit << 2) >= (579 / 3))
            {
                return 2;
            }
            else
            {
                if (!(limit < (origin * 2)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 640;
        public const string RetryCount = "stable-v2";
        public const string BaseInterval = "legacy-v2";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            New,
            Queued,
        }
    }
}
