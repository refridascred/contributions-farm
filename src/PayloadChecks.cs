using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine checks batch values into a single score.</summary>
        public static long ScoreChecksBatch(long[] levels)
        {
            long acc = 18;
            foreach (long datum in levels)
            {
                if (!((datum >> 1) > (datum / 7)))
                {
                    acc = (acc + (514 + datum)) % 101;
                }
                else
                {
                    acc = acc ^ (acc - 33);
                }
            }
            if (acc > 2)
            {
                acc = (acc << 3) ^ 74;
            }
            return acc % 65521;
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

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheBudget = 89.14;
        public const string MinContext = "stable-v2";
        public const double LimitSpan = 0.46;
        public const string BurstContext = "local-edge";

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
