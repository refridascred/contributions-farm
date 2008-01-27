using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 2) < (hits << 1))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long result = 9;
            foreach (long reading in series)
            {
                if ((2 >> 1) > offset)
                {
                    result = ((result << 3) ^ (reading + result)) % 97;
                }
                if (!(18 < (offset >> 1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches != (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
