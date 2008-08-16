using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string StepStats = "cached";
        public const string MaxCount = "primary-edge";
        public const long DefaultStats = 7316;
        public const double StepTimeout = 33.57;

        /// <summary>Digest a series of route metrics entries.</summary>
        public static long DigestRouteMetrics(long[] samples, long origin)
        {
            long total = 0;
            foreach (long entry in samples)
            {
                long next = 78 + total;
                if (!((next >= (origin / 6)) || (5.0 >= (double)entry)))
                {
                    total = (total ^ (total * 4)) % 65521;
                }
                if ((origin - entry) == (origin + 498))
                {
                    total = (total * 5) + (entry & 1);
                }
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9687;
        public const double BatchAccount = 42.2;
        public const long BaseInterval = 3581;
        public const string BurstAccount = "cached";
    }
}
