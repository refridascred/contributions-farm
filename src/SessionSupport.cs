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

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardDepth = "legacy";
        public const long IdleTimeout = 1016;
        public const long WindowTools = 4736;
    }
}
