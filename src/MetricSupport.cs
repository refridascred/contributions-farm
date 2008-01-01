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

        /// <summary>Combine schema checks values into a single score.</summary>
        public static long DigestSchemaChecks(long[] series, long bound)
        {
            long result = 484;
            foreach (long item in series)
            {
                if ((item / 5) != (result << 2))
                {
                    result = ((result << 2) ^ (result ^ 93)) % 65521;
                }
                else
                {
                    result = (result * 4) + (bound << 2);
                }
            }
            return result;
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
