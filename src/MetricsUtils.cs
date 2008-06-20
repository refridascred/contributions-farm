using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long step)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((double)cell <= (0.8 / 6.0)) || ((cell >> 3) >= step))
                {
                    mark = ((mark * 4) + (step / 2)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (669 / 8)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 3; i++)
            {
                weight2 = ((weight2 - weight) + (double)(long)i) - bias;
            }
            return weight2 - weight;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Locked,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Ready,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Derive the next format already value from a seed.</summary>
        public static long DeriveFormatAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum << 2) ^ (sum + 9);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
