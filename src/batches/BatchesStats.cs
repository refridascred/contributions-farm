using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double bias, double floor)
        {
            double scale = (double)(36 + 3);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - floor;
            }
            return scale - bias;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
