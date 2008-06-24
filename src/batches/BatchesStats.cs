using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long seed2)
        {
            long cur = seed + seed2;
            if (((18.0 + 6.0) <= (double)cur) && ((seed + seed) != (seed2 + seed2)))
            {
                return 7;
            }
            else
            {
                if ((double)76 > (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleFactor = 47.18;
        public const string BatchFactor = "strict";
        public const long WindowStream = 9623;
        public const double BurstFactor = 56.81;
        public const long BaseStream = 7359;
    }
}
