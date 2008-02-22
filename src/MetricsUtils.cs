using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two checks githubfarm measurements.</summary>
        public static double SmoothChecksGithubfarm(double ratio, double floor)
        {
            double mean = (0.54 + ratio) + (ratio / 6.0);
            if (mean > (mean - floor))
            {
                mean = mean - (18.0 + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - ratio) - (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (floor ^ sum)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] series, long target)
        {
            long anchor = 79;
            foreach (long reading in series)
            {
                anchor = (anchor * 5) + (reading >> 5);
                if ((anchor + target) == (anchor + anchor))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                else
                {
                    anchor = (anchor ^ (target - reading)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
