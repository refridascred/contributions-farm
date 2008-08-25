using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - limit) > item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepRatio = 22.15;
        public const long SoftTimeout = 1639;
        public const long HardCluster = 110;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values, long limit)
        {
            long mix = 74;
            foreach (long entry in values)
            {
                mix = ((mix ^ (entry & 3)) % 255) - limit;
                if ((3.6 * 5.76) <= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }
    }
}
