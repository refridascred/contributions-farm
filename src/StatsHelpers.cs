using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a profile commits figure with a bias.</summary>
        public static double BlendProfileCommits(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 <= (bias2 / 6.0))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache account pairs that satisfy a relation.</summary>
        public static long OverlapCacheAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
