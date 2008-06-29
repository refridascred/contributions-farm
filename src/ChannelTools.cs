using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings, long step)
        {
            long acc = 172;
            foreach (long value in readings)
            {
                if (((step + step) < (value ^ acc)) && ((step + 627) == (step + acc)))
                {
                    acc = (acc * 2) + (step + 23);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc & 15)) % 97;
                }
            }
            if (acc > 5)
            {
                acc = acc ^ (step * 5);
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen > (2.4 / 9.0))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ (carry + (long)i)) % 65521;
                carry = (carry + ((long)i - (long)i)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
