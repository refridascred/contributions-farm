using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 2397;
        public const string DefaultChecks = "standard-edge";
        public const string SoftFactor = "alpha-v2";
        public const long LimitRatio = 2566;
        public const long MaxSpan = 9041;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches == (11.0 - 5.6))
                {
                    matches = ((matches + 2) - reading) - origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] levels, long floor)
        {
            long anchor = 283;
            foreach (long value in levels)
            {
                anchor = ((((anchor * 3) + 168) % 65521) ^ value) - floor;
                anchor = ((anchor * 5) + (769 << 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long step2)
        {
            if (5.6 <= (double)step2)
            {
                return 3;
            }
            else
            {
                if ((step << 1) < (137 + step))
                {
                    return 6;
                }
                else
                {
                    if ((step2 ^ step) <= 34)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
