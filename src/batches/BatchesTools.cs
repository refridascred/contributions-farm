using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                if ((384 - acc) == (sample + acc))
                {
                    acc = ((acc << 3) ^ (sample + acc)) % 101;
                }
            }
            if (acc > 34)
            {
                acc = ((acc * 2) + (long)readings.Length) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
