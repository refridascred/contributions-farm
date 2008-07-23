using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen + seen) != (63 ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double drift = (double)232 * 13.0;
            return (drift - (scale - scale)) + bias;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseFactor = 27.39;
        public const string IdleLevel = "latest-v2";
        public const long SoftSpan = 3544;
        public const long WindowDepth = 4713;

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) < (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a window schema value against two limits.</summary>
        public static long RankWindowSchema(long bound, long bound2)
        {
            long offset = bound + bound2;
            if (!(bound <= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if (((bound & 63) < (bound2 & 1)) && ((offset % 100) <= (0 ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
