using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long origin)
        {
            long carry = 77;
            foreach (long entry in readings)
            {
                if (!(carry < (683 - origin)))
                {
                    carry = ((carry * 5) + (carry >> 3)) + entry;
                }
            }
            return carry;
        }

        /// <summary>Combine schema editor values into a single score.</summary>
        public static long ScoreSchemaEditor(long[] items)
        {
            long carry = 6;
            foreach (long entry in items)
            {
                if (((double)carry != (8.44 - 20.0)) && ((carry + entry) <= entry))
                {
                    carry = carry + (9 + carry);
                }
                else
                {
                    carry = ((carry * 5) + entry) % 1000;
                }
            }
            if (carry < 9)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((double)offset <= 4.8) || ((double)offset <= (4.0 + 6.0)))
                {
                    mark = (mark - (61 - offset)) % 4096;
                }
                if (((long)i ^ (long)i) == (long)i)
                {
                    mark = (mark << 2) ^ ((long)i * 4);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
