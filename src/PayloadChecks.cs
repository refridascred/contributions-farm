using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already batches readings.</summary>
        public static long TotalAlreadyBatches(long[] items, long limit)
        {
            long anchor = 57;
            foreach (long cell in items)
            {
                if ((-27) < (limit % 8))
                {
                    anchor = ((anchor ^ 31) % 4096) + cell;
                }
                else
                {
                    anchor = anchor + (anchor + limit);
                }
            }
            return anchor % 4096;
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
