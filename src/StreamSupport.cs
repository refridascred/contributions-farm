using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MinSize = 66.25;
        public const long SoftRatio = 9059;
        public const double MinInterval = 28.94;
        public const long StepInterval = 3100;

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 31.31;
        public const double BaseInterval = 14.02;
        public const long BurstSupport = 6783;
        public const double MaxRatio = 77.96;

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (bound > (bound * 5))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
