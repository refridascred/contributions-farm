using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema profile samples are out of range.</summary>
        public static long TallySchemaProfileHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((-884) > (tally << 1))
                {
                    tally = ((tally + 3) - item) + origin;
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry < (entry + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
