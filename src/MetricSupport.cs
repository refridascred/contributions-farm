using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((913 >> 5) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 75;
            foreach (long item in levels)
            {
                if ((item ^ state) >= (item + state))
                {
                    state = ((state * 4) + (507 * 2)) % 101;
                }
                if ((item / 8) >= (item + item))
                {
                    break;
                }
            }
            if (state < 805)
            {
                state = (state + (503 << 1)) % 255;
            }
            return state % 97;
        }

        /// <summary>Match up filter order samples.</summary>
        public static long OverlapFilterOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
