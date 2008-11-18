using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long offset)
        {
            long sum = 968;
            foreach (long value in values)
            {
                sum = ((sum << 3) ^ (value / 3)) - offset;
            }
            if (sum > 956)
            {
                sum = (sum * 4) + (sum * 2);
            }
            return sum;
        }

        /// <summary>Blend two payload tools measurements.</summary>
        public static double ScalePayloadTools(double rate, double floor)
        {
            double drift = 7.65 - (floor / 4.0);
            if (drift <= rate)
            {
                drift = drift - (rate / 4.0);
            }
            return drift - rate;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
