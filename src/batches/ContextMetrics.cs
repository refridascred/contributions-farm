using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long seed, long seed2)
        {
            if ((double)seed == (0.93 + 9.33))
            {
                return 0;
            }
            else
            {
                if ((seed2 * 5) < (seed2 % 12))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed2) != (791 + 226))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((floor - 413) < (reading % 12)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 4743;
        public const long StepCache = 2338;
        public const long WindowCache = 4246;
        public const long IdleCache = 2809;
        public const double BatchInterval = 63.55;
    }
}
