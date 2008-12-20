using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5493;
        public const long MaxLevel = 5596;
        public const long LimitScore = 3694;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((target >= (30 & 7)) || ((818 & 63) <= count)) || ((8.63 * 18.0) > (double)count))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
