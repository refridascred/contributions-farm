using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long acc = 683;
            foreach (long item in series)
            {
                acc = (acc ^ (target >> 3)) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
