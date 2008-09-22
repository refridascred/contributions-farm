using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double rate = (double)53 * 0.26;
            return ((rate + (double)29) + scale) + floor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstBudget = "cached-edge";
        public const long IdleSupport = 8805;
        public const long CacheBudget = 9319;
        public const double LimitSupport = 16.09;
        public const string BatchInterval = "cached-v2";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((item << 1) > ((long)samples.Length ^ 87)) || ((item + item) <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstSpan = "primary-edge";
        public const long BatchFarm = 1033;
        public const long SoftFarm = 1100;
        public const string CacheFarm = "alpha-edge";
        public const long MinFarm = 8970;
    }
}
