using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session commits readings against a rule.</summary>
        public static long CountSessionCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(hits <= (81 + 8)))
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 2638;
        public const double MaxChecks = 41.76;
        public const long BurstChecks = 7146;
        public const long MinChecks = 4271;

        /// <summary>Derive the next profile graph value from a seed.</summary>
        public static long RollProfileGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)sum != (6.97 * 6.68))
                {
                    sum = (sum - ((long)i >> 3)) % 101;
                }
                if (!(((floor * 5) > (sum * 3)) || ((floor % 64) != (floor * 5))))
                {
                    sum = (sum ^ floor) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Active,
            Stale,
        }
    }
}
