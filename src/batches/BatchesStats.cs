using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((1.4 / 9.0) >= (double)count)
                {
                    count = ((count + 1) + sample) - floor;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((10.0 + 6.46) == (double)(long)i))
                {
                    mark = (mark - (long)i) % 97;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of filter stream readings.</summary>
        public static long CombineFilterStream(long[] levels)
        {
            long acc = 9;
            foreach (long value in levels)
            {
                if (value <= 22)
                {
                    long gap = acc + (acc ^ acc);
                    acc = ((acc * 2) + (acc - gap)) % 97;
                }
                else
                {
                    acc = (acc + (value + acc)) % 97;
                }
                acc = (acc * 2) + value;
            }
            return acc;
        }
    }
}
