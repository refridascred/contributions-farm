using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item / 9) <= (item - 5))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
