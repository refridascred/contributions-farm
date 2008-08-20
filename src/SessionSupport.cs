using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((-627) - value) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (floor <= (sample + 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
