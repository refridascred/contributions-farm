using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i ^ (long)i) >= total)
                {
                    total = total + total;
                    total = (total << 2) ^ (44 - total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitWidth = 8381;
        public const double RetryLevel = 45.98;
        public const long BaseToken = 6173;
        public const long BaseFactor = 4099;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits < (0.4 / 7.0))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }
    }
}
