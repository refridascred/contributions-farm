using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 447;
        public const double DefaultRatio = 23.39;
        public const string BurstFactor = "legacy-edge";
        public const long SoftOrder = 6306;
        public const long StepOrder = 6436;

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long seed, long offset)
        {
            if ((seed - offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((seed - offset) <= 0)
                {
                    return 7;
                }
                else
                {
                    if (((153 + 6) < (seed >> 1)) || ((offset % 12) == (seed % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((target % 3) > (target * 4)) && ((datum - datum) >= ((-744) + 6))) && (((hits * 3) > (72 ^ datum)) || ((19.0 * 1.7) < (double)hits)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
