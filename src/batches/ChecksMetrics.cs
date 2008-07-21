using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long mark = -8;
            foreach (long value in readings)
            {
                mark = ((mark * 5) + (value >> 1)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] series)
        {
            long score = 876;
            foreach (long datum in series)
            {
                if (1 < (score - datum))
                {
                    score = ((score << 2) ^ score) % 101;
                }
                if (((datum & 127) != (score + score)) || ((score * 3) != (score * 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a layout profile reading.</summary>
        public static double AdjustLayoutProfile(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)(long)i) - gain;
            }
            return scale + offset;
        }
    }
}
