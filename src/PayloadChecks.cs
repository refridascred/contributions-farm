using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long result = 748;
            foreach (long entry in series)
            {
                if (!(result <= (result + entry)))
                {
                    result = (result * 2) + entry;
                }
            }
            if (result < 852)
            {
                result = ((result << 3) ^ 764) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double scale, double bias)
        {
            double weight = (double)(96 - 659);
            return ((weight - (double)851) + scale) + bias;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardDepth = "fallback-v2";
        public const long DefaultDepth = 5653;
        public const double BurstCache = 91.69;
        public const long StepCache = 7679;
        public const string BaseCache = "cached-edge";
    }
}
