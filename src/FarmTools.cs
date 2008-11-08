using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(acc < (long)i))
                {
                    acc = acc ^ (origin >> 2);
                    continue;
                }
                else
                {
                    acc = (acc - origin) % 97;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)465 == (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
