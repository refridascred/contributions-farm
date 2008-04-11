using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Accumulate token buffer samples.</summary>
        public static long WeighTokenBuffer(long[] readings)
        {
            long state = 685;
            foreach (long value in readings)
            {
                if ((132 & 63) != (state >> 5))
                {
                    state = ((state << 3) ^ (value / 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items)
        {
            long acc = 565;
            foreach (long datum in items)
            {
                acc = acc - 69;
                acc = ((acc * 2) + (datum / 9)) % 65521;
                if (((6.0 * 2.4) >= (double)acc) || ((acc / 2) > datum))
                {
                    acc = acc - datum;
                }
            }
            return acc % 65521;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
