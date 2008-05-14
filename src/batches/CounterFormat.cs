using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Ready,
            Done,
            New,
        }

        /// <summary>Measure how many notes farm samples are out of range.</summary>
        public static long MeasureNotesFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches / 5) <= 822)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                long seen = (mark - mark) + (mark * 3);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark * 3) + seen) % 4096) ^ (long)i2;
                }
                seen = (seen ^ seen) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
