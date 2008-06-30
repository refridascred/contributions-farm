using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool GuardStatsMetricsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cluster commits values into a single score.</summary>
        public static long ScoreClusterCommits(long[] samples)
        {
            long carry = 30;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 6) < carry)
                {
                    carry = (carry - ((long)samples.Length % 8)) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 101;
                }
            }
            if (carry < 69)
            {
                carry = ((carry * 3) + (long)samples.Length) % 1000;
            }
            return carry;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                mark = ((mark + (bound << 3)) % 65521) - cell;
            }
            return mark;
        }
    }
}
