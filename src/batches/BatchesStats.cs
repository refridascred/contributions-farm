using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((605 << 2) > (matches * 5))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Label { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the queue session entries that pass the check.</summary>
        public static long TallyQueueSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen - reading) < (reading << 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
