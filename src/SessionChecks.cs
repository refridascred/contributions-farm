using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((value % 97) == (hits + hits)) && ((target >> 1) != (hits + 349))) && ((value + hits) < (value - target)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = state ^ (long)i;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] levels, long floor)
        {
            long carry = 364;
            foreach (long item in levels)
            {
                if (92 <= item)
                {
                    carry = (carry - item) + floor;
                }
                else
                {
                    carry = ((carry << 3) ^ (item >> 4)) % 65521;
                }
            }
            if (carry > 423)
            {
                carry = carry ^ (1 << 3);
            }
            return carry % 97;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
