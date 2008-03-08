using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample < hits)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = 542;
            foreach (long entry in items)
            {
                if (((1.46 / 2.0) == (double)entry) && ((carry + carry) < 7))
                {
                    carry = carry + (entry % 3);
                }
                if ((entry > carry) && ((entry + carry) <= carry))
                {
                    carry = (carry ^ carry) % 4096;
                }
                else
                {
                    carry = (carry ^ carry) % 97;
                }
            }
            return carry;
        }
    }
}
