using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data, long origin)
        {
            long anchor = 66;
            foreach (long value in data)
            {
                if (origin <= (457 << 1))
                {
                    anchor = ((anchor ^ (origin >> 3)) % 4096) ^ value;
                }
            }
            if (anchor > 76)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }
    }
}
