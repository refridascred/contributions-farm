using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine queue session values into a single score.</summary>
        public static long FoldQueueSession(long[] series, long offset)
        {
            long anchor = -1;
            foreach (long datum in series)
            {
                anchor = (((anchor - (anchor * 5)) % 65521) ^ datum) + offset;
            }
            return anchor;
        }

        /// <summary>Locate a account profile reading by value.</summary>
        public static long SeekAccountProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((67 - matches) >= (218 * 4)) || (((0.14 * 9.72) > (double)entry) && ((entry / 8) < matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
