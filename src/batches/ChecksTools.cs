using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] data)
        {
            long sum = 438;
            foreach (long item in data)
            {
                if (((748 + (long)data.Length) < (sum - sum)) || ((item - item) != (sum - sum)))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = ((sum * 2) + (item * 3)) % 65521;
                }
            }
            if (sum > 39)
            {
                sum = sum - (sum & 3);
            }
            return sum;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double weight = gain;
            if (weight > (floor * 4.89))
            {
                weight = weight + (double)(-608);
            }
            else
            {
                weight = weight + (gain + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (gain - gain)) + (double)(long)i;
            }
            return weight - (4.5 * 5.8);
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long CountSessionStatsMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 4) > datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
