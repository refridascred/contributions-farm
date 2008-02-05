using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = 331;
            foreach (long reading in data)
            {
                if (((0.11 * 5.1) >= (double)total) && ((double)reading != (9.46 + 1.61)))
                {
                    total = total + (total + reading);
                }
            }
            return total;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 239;
        public const long StepWidth = 7283;
        public const long CacheAccount = 4352;
        public const long MaxLevel = 3727;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }
    }
}
