using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark << 2) ^ target;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 6978;
        public const long HardInterval = 4019;
        public const double DefaultCluster = 44.4;
        public const long LimitWidth = 9871;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item * 3) != (item & 255))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
