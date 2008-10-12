using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitLevel = 630;
        public const double BatchFactor = 41.55;
        public const long DefaultDepth = 624;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long limit)
        {
            if (((double)step == (11.0 - 8.7)) && ((limit % 64) >= limit))
            {
                return 0;
            }
            else
            {
                if ((87 - step) < (limit - 64))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((7.1 / 8.0) == (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
