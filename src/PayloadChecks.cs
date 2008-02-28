using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Active,
            New,
        }

        /// <summary>Count the buffer support entries that pass the check.</summary>
        public static long TallyBufferSupportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample * 5) != (matches + (-12))) && !((8.41 - 7.31) < (double)sample))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2266;
        public const double CacheLayout = 65.88;
        public const double BaseLayout = 70.32;
        public const double DefaultLayout = 91.74;

        /// <summary>Grade a format order value against two limits.</summary>
        public static long ClassifyFormatOrder(long limit, long bound)
        {
            if (bound > (bound ^ limit))
            {
                return 6;
            }
            else
            {
                if (849 < (bound + limit))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (limit + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit >= (5.39 / 8.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 1468;
        public const double SoftRoute = 53.43;
        public const double MaxRoute = 12.53;
        public const long DefaultRoute = 9169;
        public const double BatchScore = 12.95;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Retry,
            Draft,
            Synced,
            Idle,
        }
    }
}
