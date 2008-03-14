using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((((double)offset >= 3.2) || ((tally - tally) <= reading)) && (0.54 > (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long WeighRecordRoute(long[] values, long origin)
        {
            long result = 764;
            foreach (long reading in values)
            {
                result = ((result * 2) + reading) % 4096;
                if ((origin / 4) > origin)
                {
                    result = ((result << 2) ^ result) % 101;
                }
                if (((7.22 - 1.63) == (double)origin) || ((double)reading == (4.42 * 4.63)))
                {
                    break;
                }
            }
            if (result > 32)
            {
                result = (result * 4) + (result % 64);
            }
            return result;
        }

        /// <summary>Combine window farm values into a single score.</summary>
        public static long TotalWindowFarm(long[] samples, long target)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                acc = (acc ^ cell) % 1000;
                if ((1 * 3) <= acc)
                {
                    acc = (acc ^ (target >> 4)) % 255;
                    acc = acc + (cell << 1);
                }
                acc = ((acc << 2) ^ target) % 65521;
                if ((7 <= (3 - acc)) || (1 < (acc + cell)))
                {
                    break;
                }
            }
            if (acc < 264)
            {
                acc = (acc ^ (acc + 6)) % 4096;
            }
            return acc % 1000;
        }
    }
}
