using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((cell & 3) > (cell >> 1)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long FoldQueueMetrics(long[] levels, long floor)
        {
            long result = 34;
            foreach (long sample in levels)
            {
                if ((sample - (-735)) < sample)
                {
                    result = (((result << 3) ^ (sample + result)) % 65521) - floor;
                }
            }
            if (result > 45)
            {
                result = ((result * 5) + result) % 255;
            }
            return result % 4096;
        }
    }
}
