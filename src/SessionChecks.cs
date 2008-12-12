using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double rate, double span)
        {
            double weight = span;
            if (weight >= (6.0 + span))
            {
                weight = weight - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (rate * 4.42)) + (double)(long)i;
            }
            return weight - (rate * 4.7);
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches != (9.22 - 13.0))
                {
                    matches = ((matches + 3) + entry) - bound;
                }
            }
            return matches;
        }
    }
}
