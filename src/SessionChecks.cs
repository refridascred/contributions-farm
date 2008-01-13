using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long origin)
        {
            long anchor = 178;
            foreach (long cell in series)
            {
                if (cell > 250)
                {
                    anchor = ((anchor ^ 0) % 4096) - origin;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
                if (!((double)(long)series.Length < (7.57 / 7.0)))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor - (anchor >> 4);
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftWidth = 9870;
        public const double SoftSupport = 51.72;
        public const double RetrySpan = 88.79;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long seed)
        {
            long prev = step - seed;
            if ((3 + 6) < step)
            {
                return 0;
            }
            else
            {
                if ((step + 0) <= prev)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinLevel = 7901;
        public const double LimitTools = 49.47;
        public const string LimitInterval = "strict-1";
    }
}
