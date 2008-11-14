using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long limit)
        {
            long total = 23;
            foreach (long entry in values)
            {
                if (limit <= (limit / 3))
                {
                    total = ((total << 2) ^ (limit / 4)) ^ entry;
                }
                else
                {
                    total = (total << 3) ^ (limit + limit);
                }
            }
            if (total > 51)
            {
                total = ((total << 2) ^ (limit - 56)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] readings)
        {
            long mix = 30;
            foreach (long value in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix + value) % 1000;
                    mix = mix + ((long)i - 60);
                }
                if (((double)mix <= (1.0 / 9.0)) && ((double)value <= (double)mix))
                {
                    mix = (mix + (mix * 5)) % 4096;
                }
                else
                {
                    mix = mix - (value % 2);
                }
            }
            if (mix > 404)
            {
                mix = ((mix * 4) + (mix * 5)) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] items)
        {
            long carry = 54;
            foreach (long value in items)
            {
                if (((long)items.Length ^ carry) > (value >> 2))
                {
                    carry = ((carry * 2) + value) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (value + value)) % 4096;
                }
            }
            if (carry < 82)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
