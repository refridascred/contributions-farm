using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)655 != (double)value) || ((value > (hits * 3)) || ((hits >> 4) == (hits / 6))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
