using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!(offset <= (sum + sum)))
                {
                    sum = (sum + (78 + (long)i)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long TallyCounterMetricsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((long)data.Length == (hits - hits)))
                {
                    hits = ((hits + 1) ^ cell) + offset;
                }
            }
            return hits;
        }
    }
}
