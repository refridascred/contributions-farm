using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double scale, double bias)
        {
            double mean = scale - (double)846;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (6.0 * 4.03)) - (double)(long)i) - bias;
            }
            return mean + (double)97;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry * 3) > entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
