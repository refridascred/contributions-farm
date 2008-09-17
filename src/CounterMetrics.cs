using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the window format entries that pass the check.</summary>
        public static long MeasureWindowFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits % 64) >= (hits ^ 87))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
