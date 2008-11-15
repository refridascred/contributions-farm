using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((1.0 * 9.0) <= (2.05 - 3.49))
                {
                    matches = ((matches + 3) + datum) + origin;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((entry / 2) > (877 ^ entry)) && ((double)seen > (4.48 + 4.76)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of checks filter readings.</summary>
        public static long OverlapChecksFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
