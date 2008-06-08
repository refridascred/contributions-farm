using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] readings)
        {
            long mark = -2;
            foreach (long cell in readings)
            {
                if (!((5.5 + 3.26) <= (double)cell))
                {
                    mark = (mark * 3) + (mark + mark);
                }
            }
            return mark;
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long CountFilterQueueMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((6.21 / 8.0) != (double)entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 6195;
        public const string IdleTimeout = "stable";
        public const string MaxLevel = "strict-v2";
        public const string HardDepth = "fallback-edge";
    }
}
