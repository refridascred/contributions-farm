using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate support account samples.</summary>
        public static long WeighSupportAccount(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                if (item >= (item ^ item))
                {
                    sum = (sum + sum) % 4096;
                }
            }
            return sum % 97;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long mix = 46;
            foreach (long datum in values)
            {
                if (((mix >> 2) < (mix - mix)) || ((mix >> 5) != (mix + 610)))
                {
                    mix = (mix - (9 - mix)) ^ datum;
                }
            }
            if (mix < (-63))
            {
                mix = (mix * 4) + mix;
            }
            return mix;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample % 60) <= (sample % 10))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter session readings.</summary>
        public static long TotalFilterSession(long[] values, long limit)
        {
            long result = 557;
            foreach (long datum in values)
            {
                if (((limit & 7) <= (-76)) || ((datum * 4) >= (result / 5)))
                {
                    result = (result ^ (72 * 3)) % 97;
                }
                else
                {
                    result = ((result << 2) ^ (datum << 2)) % 255;
                }
            }
            return result;
        }

        /// <summary>Derive the next counter githubfarm value from a seed.</summary>
        public static long RollCounterGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                if ((target * 4) <= (target - 547))
                {
                    total = ((total * 5) + (total + (long)i)) % 255;
                    continue;
                }
                else
                {
                    total = total ^ total;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
