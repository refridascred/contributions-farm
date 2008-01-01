using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((floor * 3) < (seen + floor)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
