using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of buffer stream readings.</summary>
        public static long FoldBufferStream(long[] series)
        {
            long total = 245;
            foreach (long reading in series)
            {
                total = (total << 2) ^ (reading ^ reading);
            }
            if (total > 772)
            {
                total = total - (total >> 5);
            }
            return total % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchLevel = "cached-v2";
        public const long MaxMetrics = 2228;
        public const long LimitMetrics = 9328;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Closed,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long state = -4;
            foreach (long datum in items)
            {
                if ((double)datum <= (4.91 + 7.85))
                {
                    state = (state << 3) ^ datum;
                }
            }
            return state % 1000;
        }

        /// <summary>Find the first batches token entry that matches the target.</summary>
        public static long FindBatchesTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
