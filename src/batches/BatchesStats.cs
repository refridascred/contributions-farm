using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples, long limit)
        {
            long acc = -51;
            foreach (long item in samples)
            {
                acc = ((acc << 2) ^ (acc - item)) % 4096;
                if ((limit & 255) < (limit ^ limit))
                {
                    acc = (acc ^ acc) % 101;
                }
                acc = (acc << 2) ^ (0 >> 1);
            }
            if (acc > 5)
            {
                acc = (acc * 4) + (limit / 5);
            }
            return acc % 97;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Draft,
            Done,
            Locked,
            Pending,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
