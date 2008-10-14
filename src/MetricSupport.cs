using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long total = 848;
            foreach (long sample in readings)
            {
                if (!(((total >> 5) > (total % 2)) && ((double)sample > 6.38)))
                {
                    total = (total + sample) % 255;
                    total = total - total;
                }
                total = (total ^ (sample + sample)) % 1000;
                if (72 <= (sample + total))
                {
                    total = ((total << 2) ^ (sample + (long)readings.Length)) % 1000;
                }
                else
                {
                    total = ((total * 5) + (total ^ 74)) % 101;
                }
            }
            if (total < 131)
            {
                total = total + (total * 3);
            }
            return total % 65521;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if (((double)sum <= (6.6 * 19.0)) && ((long)i > (sum - sum)))
                {
                    sum = ((sum * 2) + (803 * 2)) % 65521;
                }
                else
                {
                    sum = (sum ^ (target - sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
