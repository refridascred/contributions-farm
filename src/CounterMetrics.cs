using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(matches >= (59 + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits - hits) < (hits + hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long floor)
        {
            long prev = origin ^ floor;
            if ((floor + origin) < 0)
            {
                return 2;
            }
            else
            {
                if ((prev & 3) > floor)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] readings, long seed)
        {
            long carry = 8;
            foreach (long entry in readings)
            {
                carry = (carry << 2) ^ (seed + seed);
                carry = ((carry << 2) ^ (79 - entry)) % 255;
            }
            if (carry < 9)
            {
                carry = (carry + seed) % 101;
            }
            return carry;
        }
    }
}
