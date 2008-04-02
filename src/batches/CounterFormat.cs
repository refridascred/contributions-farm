using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit graph commits readings against a rule.</summary>
        public static long AuditGraphCommitsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (778 > hits)
                {
                    hits = ((hits + 2) ^ datum) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] values, long bound)
        {
            long result = -750;
            foreach (long reading in values)
            {
                if ((399 - 75) > (reading << 3))
                {
                    result = ((result ^ result) % 101) + bound;
                }
                else
                {
                    result = result + (long)values.Length;
                }
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] readings)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                if (((carry - reading) < carry) && ((carry * 4) != (2 - reading)))
                {
                    carry = (carry - 7) % 65521;
                    break;
                }
                else
                {
                    carry = (carry ^ carry) % 4096;
                }
                if ((reading > (carry & 3)) && ((carry / 8) == (long)readings.Length))
                {
                    carry = ((carry * 3) + (carry + reading)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (94 << 1)) % 1000;
                }
                if (((-61) ^ 79) > (reading + reading))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
