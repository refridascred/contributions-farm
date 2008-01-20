using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + value) < (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of report graph readings.</summary>
        public static long FoldReportGraph(long[] values)
        {
            long acc = -74;
            foreach (long datum in values)
            {
                if (datum < (-3))
                {
                    acc = (acc << 2) ^ (180 * 2);
                }
                else
                {
                    acc = acc - (acc ^ 95);
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long step2)
        {
            long delta = step - step2;
            if (step >= (step - step2))
            {
                return 4;
            }
            else
            {
                if (!((step * 5) >= delta))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
