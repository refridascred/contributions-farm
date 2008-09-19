using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ (offset + 8)) % 1000;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Roll a command metric counter forward.</summary>
        public static long StepCommandMetric(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
