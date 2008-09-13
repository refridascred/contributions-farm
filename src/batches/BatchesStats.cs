using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - (mark - mark);
                if ((double)84 > (double)mark)
                {
                    mark = ((mark << 2) ^ 956) % 65521;
                    break;
                }
                else
                {
                    mark = (mark - (632 + 868)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two batch route measurements.</summary>
        public static double SmoothBatchRoute(double gain, double floor)
        {
            double scale = (double)626;
            if (scale < (double)22)
            {
                scale = scale - gain;
            }
            return scale - floor;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
