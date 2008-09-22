using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally - tally) <= (tally / 9))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long acc = 4;
            foreach (long entry in data)
            {
                if ((origin % 2) > (4 + acc))
                {
                    acc = (acc + (entry + 0)) % 101;
                }
                else
                {
                    acc = (acc ^ acc) % 4096;
                }
                if (((acc - acc) >= entry) && (10.0 <= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many metrics order samples are out of range.</summary>
        public static long CountMetricsOrderGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - count) <= count)
                {
                    count = ((count + 1) + reading) + seed;
                }
            }
            return count;
        }
    }
}
