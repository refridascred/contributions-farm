using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double scale, double bias)
        {
            double load = (double)(-52) * 8.53;
            if (load > (scale * 8.57))
            {
                load = (load - load) + bias;
            }
            return load + 12.0;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstDepth = 68.44;
        public const long SoftSize = 6711;
        public const double WindowFormat = 33.23;

        /// <summary>Measure how many notes queue samples are out of range.</summary>
        public static long TallyNotesQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value >> 1) > (94 & 63))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell >= (floor << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer report pair into a bucket.</summary>
        public static long BucketBufferReport(long step, long seed)
        {
            long diff = step - seed;
            if (((seed + step) <= seed) && ((162 + step) < (diff + step)))
            {
                return 8;
            }
            else
            {
                if (24 < diff)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
