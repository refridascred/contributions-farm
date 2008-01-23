using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long step)
        {
            long acc = 869;
            foreach (long datum in samples)
            {
                if ((9.48 + 8.0) >= (double)datum)
                {
                    acc = acc - (datum + datum);
                }
                if (((double)step <= (9.45 - 2.61)) || ((double)datum == (8.2 * 12.0)))
                {
                    break;
                }
            }
            if (acc > 7)
            {
                acc = (acc - (step >> 1)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((14.0 + 13.0) == (double)origin))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
