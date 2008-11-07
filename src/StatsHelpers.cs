using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the payload order entries that pass the check.</summary>
        public static long TallyPayloadOrderMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((((tally / 6) <= origin) && ((double)origin <= (double)tally)) && ((tally ^ origin) >= (origin << 3)))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long limit)
        {
            long carry = 1;
            foreach (long reading in levels)
            {
                if ((reading >> 1) > reading)
                {
                    carry = ((carry * 4) + (reading % 60)) % 4096;
                }
                if (reading > (limit / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Measure how many stream editor samples are out of range.</summary>
        public static long AuditStreamEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((7.6 + 2.9) != (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) > cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
