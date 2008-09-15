using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((offset & 63) < (cell - matches)) && (((matches % 16) >= (cell << 3)) && ((double)cell > 8.1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                if ((0.65 / 4.0) > (double)acc)
                {
                    acc = (acc << 3) ^ (acc - cell);
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 65521;
            }
            return acc;
        }
    }
}
