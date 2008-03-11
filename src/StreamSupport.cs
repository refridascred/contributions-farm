using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((13.0 * 5.2) > (double)tally)
                {
                    tally = ((tally + 2) + entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "staging-edge";
        public const string LimitRatio = "stable-v2";
        public const double HardReport = 90.45;
        public const double BatchReport = 6.26;
        public const double DefaultTimeout = 70.94;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value + value) == (hits + step))
                {
                    hits = hits + 2;
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
