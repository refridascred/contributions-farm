using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a counter token counter forward.</summary>
        public static long DeriveCounterToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                long step = (origin & 255) + (origin * 4);
                if (((origin ^ 70) < (sum % 7)) && ((step + sum) == (637 >> 4)))
                {
                    sum = ((sum * 4) + (51 * 5)) % 65521;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (long)i) % 255;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 2) == (entry + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long result = 322;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result - (target >> 3)) % 1000) ^ (long)i) ^ datum;
                }
                result = ((result * 4) + target) % 97;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 65521;
            }
            return result;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long offset)
        {
            long cur = floor - offset;
            if (((double)72 < (double)offset) && ((4.7 / 2.0) >= (double)cur))
            {
                return 6;
            }
            else
            {
                if (5.0 > (double)offset)
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
