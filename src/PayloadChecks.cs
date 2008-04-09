using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] readings, long origin)
        {
            long score = -6;
            foreach (long value in readings)
            {
                if ((4.5 - 12.0) < (double)origin)
                {
                    score = ((score ^ (origin % 8)) % 101) ^ value;
                }
            }
            if (score < 4)
            {
                score = score ^ 25;
            }
            return score;
        }

        /// <summary>Locate a batch farm reading by value.</summary>
        public static long LookupBatchFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks profile samples.</summary>
        public static long WeighChecksProfile(long[] samples)
        {
            long carry = 431;
            foreach (long value in samples)
            {
                if ((carry <= (value / 6)) && ((value * 3) >= (-6)))
                {
                    carry = ((carry * 2) + (carry - carry)) % 97;
                }
                else
                {
                    carry = (carry - (value + value)) % 101;
                }
            }
            if (carry > 7)
            {
                carry = (carry - (5 * 5)) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of schema queue readings.</summary>
        public static long TallySchemaQueue(long[] levels, long target)
        {
            long acc = 4;
            foreach (long datum in levels)
            {
                if (((8 - datum) <= target) || (((-19) ^ 50) >= (target - 416)))
                {
                    acc = (acc - (target ^ 6)) % 1000;
                }
                if ((acc + 27) >= (target >> 4))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long target, long seed)
        {
            if (((target % 7) <= (target * 2)) && ((target * 3) != (target >> 2)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((target + 923) < 97)
                    {
                        return 7;
                    }
                    else
                    {
                        if (8 > (target - seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
