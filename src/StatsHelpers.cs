using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long origin)
        {
            long mark = 45;
            foreach (long item in readings)
            {
                if ((double)item > (18.0 - 6.48))
                {
                    mark = (mark + (-98)) + origin;
                }
            }
            return mark;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark << 2) ^ target;
                if ((double)(long)i <= (double)mark)
                {
                    mark = (mark - (mark << 1)) % 65521;
                    mark = ((mark << 3) ^ (488 << 3)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long FoldAccountAlready(long[] readings)
        {
            long carry = -411;
            foreach (long item in readings)
            {
                if ((item & 1) < (52 * 3))
                {
                    carry = carry ^ item;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + (carry - carry)) % 255;
            }
            return carry;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((cell - seen) != (cell / 6)) && ((13.0 - 3.0) <= (double)limit)) || (seen >= (cell << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
