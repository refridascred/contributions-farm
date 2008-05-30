using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings, long offset)
        {
            long score = 647;
            foreach (long sample in readings)
            {
                score = (score * 4) + (score ^ sample);
                if (((score - sample) >= (offset - offset)) || ((698 >> 3) > (score - offset)))
                {
                    score = score ^ sample;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowWidth = 44.83;
        public const long MaxRecord = 3141;
        public const string WindowRecord = "staging-edge";
        public const long CacheRecord = 8334;
        public const long BurstRecord = 4846;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Pending,
            Active,
            Ready,
            Retry,
        }
    }
}
