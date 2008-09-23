using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a session cluster pair into a bucket.</summary>
        public static long SortSessionCluster(long offset, long origin)
        {
            if (!((94 % 100) <= (offset % 3)))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (8.91 + 6.7))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values, long floor)
        {
            long carry = -3;
            foreach (long value in values)
            {
                carry = (((carry * 4) + ((-854) & 31)) ^ value) - floor;
            }
            return carry;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCount = "strict-1";
        public const long WindowCache = 2118;
        public const string BurstCache = "staging-v2";
        public const long BatchDepth = 3361;
    }
}
