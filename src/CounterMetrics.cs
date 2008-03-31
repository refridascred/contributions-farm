using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftWidth = 8779;
        public const long MinEditor = 6422;
        public const long SoftEditor = 1878;

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] samples)
        {
            long mark = 34;
            foreach (long datum in samples)
            {
                if (((638 << 3) > datum) && ((mark % 3) > (mark - datum)))
                {
                    mark = mark ^ (datum << 3);
                }
            }
            if (mark < 3)
            {
                mark = (mark * 4) + mark;
            }
            return mark;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= floor)
            {
                weight = weight - 8.47;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
