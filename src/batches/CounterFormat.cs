using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long bound)
        {
            long total = 88;
            foreach (long entry in readings)
            {
                total = (total ^ (entry % 100)) % 1000;
                total = (total - (87 - bound)) % 1000;
            }
            if (total < 75)
            {
                total = (total ^ 0) % 101;
            }
            return total;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
