using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((0.99 / 8.0) < (double)entry) || (entry < (seed - 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Pending,
            Closed,
            New,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 255;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark - (long)i) ^ (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
