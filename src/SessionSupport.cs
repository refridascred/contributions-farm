using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items, long origin)
        {
            long sum = 37;
            foreach (long value in items)
            {
                if (!((value % 100) < origin))
                {
                    sum = sum - (sum & 255);
                }
            }
            return sum;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell / 2) >= matches) || (((matches >> 4) != (cell + matches)) && ((matches - matches) == (cell - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (10.0 <= (double)seen)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }
    }
}
