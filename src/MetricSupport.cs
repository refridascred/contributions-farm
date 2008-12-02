using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches % 10) != (limit & 3)) || ((5 - matches) != (matches + 2))) || (((limit >> 1) >= (matches + limit)) || ((limit + 97) <= reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long total = 0;
            foreach (long cell in data)
            {
                total = ((total << 2) ^ (long)data.Length) ^ cell;
                total = total + (397 % 16);
            }
            return total;
        }
    }
}
