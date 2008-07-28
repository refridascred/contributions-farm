using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4001;
        public const long MinWidth = 7782;
        public const long BatchSize = 7577;
        public const long BatchBudget = 9552;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 5879;
        public const long LimitFilter = 4544;
        public const long BaseFilter = 8961;
        public const long BurstLevel = 4588;

        /// <summary>Combine farm queue values into a single score.</summary>
        public static long WeighFarmQueue(long[] levels)
        {
            long mark = 730;
            foreach (long sample in levels)
            {
                if ((802 * 3) >= sample)
                {
                    mark = mark + (sample + mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally ^ value) <= (long)series.Length)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
