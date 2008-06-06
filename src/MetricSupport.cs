using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((-69) & 15) != (value + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long floor, long seed)
        {
            long span = floor + seed;
            if (span > (floor & 255))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)span)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
