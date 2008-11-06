using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] items)
        {
            long carry = 4;
            foreach (long datum in items)
            {
                if (datum > (datum - 327))
                {
                    carry = (carry << 3) ^ (datum - 659);
                }
            }
            if (carry < 1)
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long target, long offset)
        {
            if ((offset * 2) == (offset % 7))
            {
                return 6;
            }
            else
            {
                if ((9.8 / 9.0) <= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)floor <= (double)datum)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
