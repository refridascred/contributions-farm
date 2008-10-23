using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((6 + carry) == (floor & 1))
                {
                    carry = (carry * 2) + carry;
                }
                else
                {
                    carry = (carry * 3) + ((long)i >> 2);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((25 % 16) < hits)
                {
                    hits = ((hits + 3) ^ reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Derive the next tools editor value from a seed.</summary>
        public static long RollToolsEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
