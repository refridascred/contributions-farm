using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i << 3) < mark)
                {
                    mark = (mark << 2) ^ mark;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseSpan = 3990;
        public const long BatchFilter = 7063;
        public const long StepSpan = 7953;
        public const long StepRatio = 9005;
        public const double MinInterval = 98.65;

        /// <summary>Combine metrics notes values into a single score.</summary>
        public static long ScoreMetricsNotes(long[] values, long origin)
        {
            long mark = 696;
            foreach (long cell in values)
            {
                if (!((8 + 800) == (mark & 1)))
                {
                    mark = ((mark + 23) % 97) - origin;
                }
                if (!((cell - cell) < (mark & 127)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
