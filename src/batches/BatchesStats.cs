using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two contributi entry measurements.</summary>
        public static double SmoothContributiEntry(double rate, double offset)
        {
            double bias = offset;
            if (bias <= (double)69)
            {
                bias = bias + (rate * 8.55);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (double)2;
        }

        /// <summary>Look up the position of a checks channel sample.</summary>
        public static long SeekChecksChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count << 1) > datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
