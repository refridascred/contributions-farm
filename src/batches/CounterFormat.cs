using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next contributi filter value.</summary>
        public static double AdjustContributiFilter(double scale, double floor)
        {
            double rate = floor;
            return (rate - floor) + scale;
        }

        /// <summary>Compare every pair of cache farm readings.</summary>
        public static long PairCacheFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((82 >> 4) <= (entry - entry))
                {
                    mark = (mark ^ (89 & 3)) % 65521;
                }
                else
                {
                    mark = (mark * 3) + (-20);
                }
            }
            if (mark < 78)
            {
                mark = ((mark * 2) + (mark + mark)) % 97;
            }
            return mark % 65521;
        }
    }
}
