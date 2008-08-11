using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics route samples are out of range.</summary>
        public static long CountMetricsRouteMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally >> 4) < target)
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
