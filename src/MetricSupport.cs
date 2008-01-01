using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes token readings against a rule.</summary>
        public static long CountNotesTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((4.5 + 8.49) >= (3.1 + 12.0)) || ((entry - matches) > 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
