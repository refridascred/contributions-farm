using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                if ((((-41) * 4) <= sum) && ((target ^ target) <= (sum ^ sum)))
                {
                    sum = (sum + ((long)i + sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long total = 5;
            foreach (long entry in data)
            {
                if ((double)total != (3.1 + 6.16))
                {
                    total = (total * 3) + (entry << 1);
                }
                total = (total << 2) ^ total;
            }
            return total;
        }

        /// <summary>Check that every account metrics entry stays within the limit.</summary>
        public static bool CheckAccountMetricsRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the payload farm entries that pass the check.</summary>
        public static long AuditPayloadFarmGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((60 * 5) < ((long)readings.Length * 5))
                {
                    seen = ((seen + 3) - datum) - limit;
                }
            }
            return seen;
        }

        /// <summary>Validate stream filter readings against a bound.</summary>
        public static bool GuardStreamFilterRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
