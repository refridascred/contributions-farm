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

        /// <summary>Roll a schema context counter forward.</summary>
        public static long StepSchemaContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark * 2) + mark;
                if (!((long)i <= ((long)i & 127)))
                {
                    mark = mark ^ 584;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
