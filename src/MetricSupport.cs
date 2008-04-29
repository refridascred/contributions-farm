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

        /// <summary>Adjust a layout payload reading.</summary>
        public static double BlendLayoutPayload(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= span)
            {
                scale2 = (scale2 + (double)30) + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (double)(-63)) + (double)(long)i;
            }
            return scale2 - (scale2 * 7.22);
        }

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
