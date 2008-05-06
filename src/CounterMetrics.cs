using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = mark - (floor + floor);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark ^ (floor - mark)) % 101) ^ (long)i2;
                }
                mark = (mark << 3) ^ (mark << 2);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 <= (2.27 + weight2))
            {
                weight2 = weight2 - (weight2 - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 + weight2)) - (double)(long)i;
            }
            return weight2 - floor;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count githubfarm profile pairs that satisfy a relation.</summary>
        public static long PairGithubfarmProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
