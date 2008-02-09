using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (5.6 * 3.58))
                {
                    tally = ((tally + 2) ^ sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry - (19 + carry)) % 97;
                if ((carry + 69) >= offset)
                {
                    carry = (carry - (offset + offset)) % 4096;
                    carry = ((carry << 2) ^ (7 - offset)) % 65521;
                }
                else
                {
                    carry = (carry * 3) + (carry % 12);
                }
                carry = (carry ^ (long)i) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every order stats entry stays within the limit.</summary>
        public static bool ValidateOrderStatsBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] data)
        {
            long score = 950;
            foreach (long value in data)
            {
                score = ((score * 4) + (value + score)) % 1000;
                if (value <= score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long step = target ^ limit;
            if (!((7.93 * 1.18) < (double)step))
            {
                return 4;
            }
            else
            {
                if (!((17.0 - 8.0) <= (double)step))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
