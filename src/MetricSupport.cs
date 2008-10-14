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

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "standard";
        public const long SoftTimeout = 4325;
        public const string CacheSpan = "latest-edge";
        public const long BaseCounter = 8377;

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
