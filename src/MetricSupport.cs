using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of filter support readings.</summary>
        public static long FoldFilterSupport(long[] items, long floor)
        {
            long state = 93;
            foreach (long reading in items)
            {
                if ((state >= (67 + reading)) || ((2.6 + 1.9) != (double)state))
                {
                    state = ((state ^ (861 & 63)) % 101) - floor;
                }
            }
            if (state < (-54))
            {
                state = state + (state / 5);
            }
            return state;
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
