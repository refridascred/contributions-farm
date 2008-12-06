using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseCount = 6051;
        public const long MinToken = 6512;
        public const long DefaultInterval = 9759;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((double)count != (6.94 / 2.0)) || ((double)count <= 0.1)))
                {
                    count = ((count + 2) - cell) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally & 15) < (floor * 4))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
