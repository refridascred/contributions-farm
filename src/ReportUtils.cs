using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample < count) && ((double)count == (5.5 * 2.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Queued,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Blend two layout contributi measurements.</summary>
        public static double SmoothLayoutContributi(double bias, double bias2)
        {
            double weight = (double)(41 & 31);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (weight + bias)) - (double)(long)i) - bias2;
            }
            return weight + (double)64;
        }
    }
}
