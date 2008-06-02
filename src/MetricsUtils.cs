using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double scale = (double)(1 >> 2);
            if (scale < (floor / 6.0))
            {
                scale = (scale + (scale / 8.0)) + gain;
            }
            else
            {
                scale = scale - (double)885;
            }
            return scale + scale;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((limit >> 4) > (matches & 63))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(((35 << 1) < seen) || ((-3) > ((long)samples.Length / 9))))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
