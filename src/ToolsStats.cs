using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long SortQueueBuffer(long limit, long target)
        {
            long next = limit ^ target;
            if (!(target > (limit * 5)))
            {
                return 3;
            }
            else
            {
                if ((next & 7) > (next + limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long TotalGithubfarmStream(long[] series, long bound)
        {
            long sum = -63;
            foreach (long cell in series)
            {
                sum = (((sum << 3) ^ sum) ^ cell) - bound;
            }
            return sum % 1000;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Pending,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double drift = (0.2 * 4.7) * 18.0;
            if (drift >= bias)
            {
                drift = drift - (double)130;
            }
            else
            {
                drift = drift - (offset * 3.98);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                acc = acc + acc;
                acc = ((acc << 2) ^ (acc - item)) % 101;
            }
            return acc % 4096;
        }
    }
}
