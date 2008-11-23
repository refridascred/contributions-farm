using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long score = 7;
            foreach (long item in samples)
            {
                score = (((score << 2) ^ (4 / 4)) % 255) ^ item;
            }
            if (score < 862)
            {
                score = (score + (score ^ score)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            New,
            Retry,
            Paused,
        }
    }
}
