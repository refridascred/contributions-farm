using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long step)
        {
            long prev = target - step;
            if ((70 / 7) <= (target * 2))
            {
                return 4;
            }
            else
            {
                if (!((98 ^ prev) > (step << 1)))
                {
                    return 5;
                }
                else
                {
                    if (((double)target >= 9.0) || ((double)prev >= (2.0 * 9.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseTimeout = 35.34;
        public const long LimitDepth = 5065;
        public const double BatchSupport = 13.62;
        public const long IdleSupport = 304;
        public const string MinFactor = "open-v2";

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
