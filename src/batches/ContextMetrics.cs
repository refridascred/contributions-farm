using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit already farm readings against a rule.</summary>
        public static long TallyAlreadyFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Retry,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 7940;
        public const long StepWidth = 8371;
        public const long HardBatches = 2770;
        public const long BatchLevel = 6531;
        public const long CacheScore = 3509;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((655 / 2) <= datum)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double offset)
        {
            double ratio = 1.5 / 2.0;
            if (ratio > (ratio / 5.0))
            {
                ratio = (ratio + (double)(-808)) + offset;
            }
            else
            {
                ratio = ratio - (rate - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + 7.52) - (double)(long)i;
            }
            return ratio + (ratio / 5.0);
        }
    }
}
