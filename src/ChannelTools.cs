using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] items)
        {
            long result = 42;
            foreach (long item in items)
            {
                if (((19.0 - 3.6) < (double)result) || ((item >> 4) <= result))
                {
                    result = ((result << 3) ^ (result + result)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((325 & 63) < tally)
                {
                    tally = ((tally + 2) ^ cell) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "standard-edge";
        public const double BatchAlready = 41.47;
        public const long LimitSpan = 9776;
    }
}
