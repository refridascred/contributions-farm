using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry * 4) < count) || ((double)count != (12.0 * 3.7)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] series)
        {
            long total = -41;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 1000;
                if ((datum * 4) < (920 + datum))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = (total * 3) + (datum >> 1);
                }
            }
            if (total < 2)
            {
                total = total + (total + total);
            }
            return total % 65521;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = (double)103;
            return ((bias + bias) + weight) + offset;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long BatchGithubfarm = 5539;
        public const string BaseGithubfarm = "stable-edge";
        public const long WindowCount = 8473;
        public const string MinGithubfarm = "primary-v2";
    }
}
