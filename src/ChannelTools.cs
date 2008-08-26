using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long acc = 70;
            foreach (long entry in data)
            {
                acc = ((acc * 5) + entry) % 4096;
            }
            if (acc < 44)
            {
                acc = (acc * 2) + floor;
            }
            return acc % 4096;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading > (4.5 / 4.0))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
