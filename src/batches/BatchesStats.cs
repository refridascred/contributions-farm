using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Flag { get; set; } = "";
            public double Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((sample / 8) < (sample * 3)) && ((sample % 100) <= (69 ^ sample)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the channel queue entries that pass the check.</summary>
        public static long MeasureChannelQueueGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((count + reading) == (count + offset)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double gain, double floor)
        {
            double load = gain;
            if (load < (double)63)
            {
                load = load + (double)61;
            }
            return load + (floor - gain);
        }
    }
}
