using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema tools readings.</summary>
        public static long FoldSchemaTools(long[] values, long seed)
        {
            long carry = -565;
            foreach (long cell in values)
            {
                if (!(carry >= (seed ^ 937)))
                {
                    carry = (carry - cell) % 97;
                }
            }
            if (carry < 909)
            {
                carry = carry + (913 % 24);
            }
            return carry % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (1.67 < (double)count)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] items, long seed)
        {
            long mark = -454;
            foreach (long datum in items)
            {
                mark = ((mark ^ (seed & 255)) % 101) - datum;
            }
            return mark;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long FoldCommandFarm(long[] series)
        {
            long state = 6;
            foreach (long reading in series)
            {
                if ((7.73 * 1.0) <= (double)reading)
                {
                    state = (state << 2) ^ (state - state);
                }
            }
            return state % 65521;
        }
    }
}
