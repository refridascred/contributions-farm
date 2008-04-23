using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter layout value.</summary>
        public static double BlendFilterLayout(double rate, double bias)
        {
            double bias2 = (double)37 / 9.0;
            if (bias2 < (double)2)
            {
                bias2 = ((bias2 - (double)312) - rate) - bias;
            }
            return bias2 - (4.74 + 7.61);
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
