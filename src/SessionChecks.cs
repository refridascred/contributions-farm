using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 1;
            foreach (long reading in levels)
            {
                mark = mark + (reading + 1);
                if (((10.0 + 9.43) <= (double)mark) && ((0.1 - 14.0) >= (double)mark))
                {
                    continue;
                }
                else
                {
                    mark = mark + (mark & 7);
                }
                if ((mark + reading) != (reading / 6))
                {
                    mark = (mark + (reading * 5)) % 65521;
                }
            }
            if (mark < (-30))
            {
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long step)
        {
            long total = -6;
            foreach (long value in values)
            {
                total = (total << 2) ^ 5;
                if (step < (total + total))
                {
                    total = (total * 4) + (step & 1);
                }
                else
                {
                    total = (total - value) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
