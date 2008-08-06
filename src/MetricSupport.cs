using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + count) <= (count - 895)) && !((double)cell >= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
