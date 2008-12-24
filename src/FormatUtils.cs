using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of counter schema entries.</summary>
        public static long TotalCounterSchema(long[] levels)
        {
            long sum = 546;
            foreach (long sample in levels)
            {
                if ((sum + 425) < 65)
                {
                    sum = (sum + (sum + 12)) + sample;
                }
                else
                {
                    sum = (sum * 3) + (sum ^ sum);
                }
            }
            if (sum < 658)
            {
                sum = (sum ^ 5) % 65521;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 9256;
        public const long MaxTimeout = 6542;
        public const string StepGithubfarm = "standard-edge";

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = 1.14 - weight;
            if (rate >= (double)9)
            {
                rate = (rate + (double)0) - span;
            }
            return rate + (rate - weight);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (count <= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = sum + offset;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double offset)
        {
            double rate = (double)(0 + 611);
            return (rate - (offset * 5.6)) + bias;
        }
    }
}
