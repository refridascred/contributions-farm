using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryCount = 4807;
        public const long BurstDepth = 884;
        public const long SoftSize = 8413;

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardDepth = 3133;
        public const string HardEditor = "legacy-v2";
        public const long WindowEditor = 8032;
        public const long RetryScore = 4012;
        public const long DefaultFactor = 9489;

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mark = 4;
            foreach (long item in levels)
            {
                if (!((869 >> 4) < (item + (long)levels.Length)))
                {
                    mark = (mark * 4) + (8 - 773);
                }
                else
                {
                    mark = mark + (item - item);
                }
            }
            return mark;
        }
    }
}
