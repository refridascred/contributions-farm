using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2219;
        public const double BurstSupport = 53.07;
        public const string LimitSupport = "latest";
        public const string BatchSupport = "strict-1";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)tally < (1.14 + 8.68)) || ((tally + value) >= (value * 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
