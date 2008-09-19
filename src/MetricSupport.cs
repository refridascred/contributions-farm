using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two githubfarm window measurements.</summary>
        public static double ProjectGithubfarmWindow(double gain, double bias)
        {
            double scale = (double)(97 ^ 32);
            if (scale > (4.5 + bias))
            {
                scale = (scale + scale) - gain;
            }
            return scale + 2.0;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)count <= (2.82 * 3.6)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((8.33 - 7.0) != (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
