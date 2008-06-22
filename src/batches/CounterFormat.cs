using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 3.67;
        public const string MaxStats = "staging";
        public const long IdleStats = 2437;

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings)
        {
            long sum = -199;
            foreach (long datum in readings)
            {
                if ((sum / 8) < (datum - sum))
                {
                    sum = ((sum * 5) + ((long)readings.Length % 16)) % 4096;
                    break;
                }
                if ((37 >> 5) >= (sum - 1))
                {
                    sum = (sum - (9 - sum)) % 101;
                }
                else
                {
                    sum = (sum - (sum + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Check that every counter batches entry stays within the limit.</summary>
        public static bool GuardCounterBatchesRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
