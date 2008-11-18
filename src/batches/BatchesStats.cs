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

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples)
        {
            long sum = -4;
            foreach (long reading in samples)
            {
                if (((sum >> 1) < reading) && ((reading >> 5) == (sum - sum)))
                {
                    sum = ((sum * 4) + (sum / 5)) % 65521;
                }
            }
            return sum % 1000;
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
