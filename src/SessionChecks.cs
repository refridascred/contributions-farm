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

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (777 <= seen)
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
