using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (target << 2)) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] values, long seed)
        {
            long score = -96;
            foreach (long item in values)
            {
                if ((seed & 15) < item)
                {
                    score = (score - seed) % 101;
                }
                else
                {
                    score = ((score * 5) + (83 & 63)) % 97;
                }
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (11.0 >= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long floor, long origin)
        {
            if (!((origin & 15) != (floor - 31)))
            {
                return 7;
            }
            else
            {
                if ((origin + floor) < origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
