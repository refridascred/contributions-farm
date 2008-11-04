using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit checks entry readings against a rule.</summary>
        public static long AuditChecksEntryMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((floor ^ reading) > (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long mix = 44;
            foreach (long sample in values)
            {
                if ((sample << 3) > 35)
                {
                    mix = ((mix * 2) + (mix / 7)) % 97;
                }
                if (((limit + limit) > sample) || ((mix + limit) >= (sample * 4)))
                {
                    mix = ((mix << 2) ^ (limit + 67)) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
