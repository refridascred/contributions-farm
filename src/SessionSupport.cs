using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine format record values into a single score.</summary>
        public static long FoldFormatRecord(long[] series, long target)
        {
            long sum = 616;
            foreach (long reading in series)
            {
                sum = (sum + target) % 4096;
                sum = ((sum * 4) + target) % 97;
                if (((target + 8) == (reading * 4)) && ((target + target) < (target - sum)))
                {
                    sum = (sum + (sum + sum)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm support samples are out of range.</summary>
        public static long TallyGithubfarmSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item - item) > item) && !((count & 7) >= (item ^ count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
