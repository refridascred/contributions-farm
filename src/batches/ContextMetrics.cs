using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long carry = 794;
            foreach (long sample in levels)
            {
                carry = (((carry * 5) + (carry % 2)) % 1000) ^ sample;
                carry = carry + carry;
            }
            if (carry > 692)
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitBudget = 9991;
        public const long BaseRatio = 3180;
        public const long SoftInterval = 2940;
        public const long BaseSize = 1325;

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long CountTokenOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((7.0 - 9.1) != (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit route cache readings against a rule.</summary>
        public static long MeasureRouteCacheHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading & 127) == (497 - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi metrics value against two limits.</summary>
        public static long BucketContributiMetrics(long step, long step2)
        {
            if ((3.13 * 6.0) == (double)step)
            {
                return 3;
            }
            else
            {
                if ((59 * 5) >= (step ^ step2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
