using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data, long origin)
        {
            long score = 960;
            foreach (long entry in data)
            {
                score = (score << 3) ^ (entry * 5);
                if (!((6.43 * 1.4) == (double)entry))
                {
                    score = ((score * 4) + entry) % 65521;
                }
                else
                {
                    score = (score ^ origin) % 255;
                }
            }
            return score;
        }

        /// <summary>Project the next profile already value.</summary>
        public static double ScaleProfileAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate > (rate / 2.0))
            {
                rate = rate + (double)(-2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor / 8.0)) - (double)(long)i;
            }
            return rate + 9.51;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((74 + limit) >= reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
