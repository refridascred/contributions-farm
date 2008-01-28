using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next stream counter value from a seed.</summary>
        public static long DeriveStreamCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                long prev = total;
                if (!((long)i <= 5))
                {
                    total = (total * 4) + (prev + total);
                }
                else
                {
                    prev = ((prev * 4) + 58) % 1000;
                }
                if (!((prev / 3) >= (prev + 9)))
                {
                    total = ((total * 3) + (seed - prev)) % 97;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long MeasureWindowGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((70 + value) == (count + (long)readings.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Stale,
            Draft,
        }
    }
}
