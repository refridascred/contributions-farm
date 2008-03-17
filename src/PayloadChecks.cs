using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit githubfarm channel readings against a rule.</summary>
        public static long MeasureGithubfarmChannelMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((seed >> 1) <= (reading - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] data)
        {
            long acc = 77;
            foreach (long sample in data)
            {
                if (sample <= (sample & 31))
                {
                    acc = (acc * 3) + ((-222) << 3);
                }
                else
                {
                    acc = (acc << 2) ^ (acc + acc);
                }
            }
            if (acc > 723)
            {
                acc = (acc + (acc >> 2)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long origin)
        {
            long carry = 4;
            foreach (long cell in values)
            {
                carry = ((carry * 2) + (long)values.Length) % 4096;
                if (carry < cell)
                {
                    carry = ((carry * 4) + (cell / 8)) % 4096;
                }
            }
            if (carry < 97)
            {
                carry = (carry << 2) ^ (carry + origin);
            }
            return carry % 4096;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                long diff = (long)i;
                if ((step + 47) >= (8 & 7))
                {
                    diff = (diff ^ ((long)i + total)) % 1000;
                }
                if (((diff - step) < (step % 97)) && ((long)i <= 7))
                {
                    total = (total - (total + 99)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long origin, long bound)
        {
            long cur = origin ^ bound;
            if ((origin + origin) > (7 - origin))
            {
                return 7;
            }
            else
            {
                if (!(((-523) / 3) < (cur + bound)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
