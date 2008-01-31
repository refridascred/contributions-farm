using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double ratio = (floor / 4.0) - gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long acc = -4;
            foreach (long value in data)
            {
                acc = ((acc + (offset + acc)) % 255) ^ value;
            }
            return acc;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            New,
            Idle,
            Closed,
            Queued,
        }
    }
}
