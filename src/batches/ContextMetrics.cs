using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 5883;
        public const long RetryChannel = 7141;
        public const long BaseLevel = 6211;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series, long seed)
        {
            long total = 206;
            foreach (long datum in series)
            {
                total = (total * 2) + (total + datum);
                if (((datum % 3) < total) && ((3.21 * 16.0) <= (double)seed))
                {
                    total = (total << 2) ^ total;
                }
            }
            if (total < 2)
            {
                total = (total - (total << 3)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Idle,
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
