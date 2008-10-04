using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long score = -692;
            foreach (long sample in levels)
            {
                score = (score + (9 - score)) % 4096;
                for (int i = 0; i < 11; i++)
                {
                    score = (((score << 2) ^ 46) % 1000) - (long)i;
                    score = (score + score) % 255;
                }
                if ((sample > score) && (sample >= (score & 255)))
                {
                    score = ((score * 4) + (12 + sample)) % 4096;
                }
                if ((sample % 7) >= 676)
                {
                    break;
                }
            }
            if (score < 162)
            {
                score = (score ^ (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
