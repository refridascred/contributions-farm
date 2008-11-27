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

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (((acc * 5) + (cell + acc)) % 255) + (long)i;
                    acc = (acc ^ (acc + cell)) % 65521;
                }
                acc = (acc * 2) + (acc / 7);
                acc = acc + (cell & 127);
                if ((double)cell >= (6.3 - 17.0))
                {
                    break;
                }
            }
            if (acc < 48)
            {
                acc = (acc ^ (acc - acc)) % 97;
            }
            return acc;
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
