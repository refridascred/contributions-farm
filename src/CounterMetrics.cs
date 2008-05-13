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

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6929;
        public const long StepWindow = 5753;
        public const long BaseDepth = 4087;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (double)matches) || !((matches - 253) < (entry + 93)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((5 * 4) == ((long)i % 64))
                {
                    acc = ((acc * 4) + (53 + acc)) % 65521;
                    continue;
                }
                acc = (acc * 3) + (origin * 4);
                if ((acc > (acc << 2)) && ((5.2 / 6.0) > (double)(long)i))
                {
                    acc = (acc * 5) + (acc + origin);
                }
                else
                {
                    acc = acc ^ (origin - origin);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
