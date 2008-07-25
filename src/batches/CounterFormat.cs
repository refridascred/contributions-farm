using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((425 ^ matches) >= (datum + 72))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((8.4 * 18.0) >= (double)tally) || (item >= ((long)samples.Length >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
