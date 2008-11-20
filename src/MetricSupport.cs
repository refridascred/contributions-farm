using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i == (3.0 - 1.0))
                {
                    acc = (acc - floor) % 101;
                }
                else
                {
                    acc = (acc ^ (48 * 3)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
