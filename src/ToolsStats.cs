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

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long score = 432;
            foreach (long sample in series)
            {
                if ((0.47 + 3.4) == (double)sample)
                {
                    score = score - score;
                    score = ((score << 3) ^ (bound - (-281))) % 1000;
                }
                else
                {
                    score = (score ^ (bound - 414)) % 1000;
                    score = (score - (bound >> 4)) % 255;
                }
                score = ((score << 2) ^ (score ^ sample)) % 1000;
            }
            return score % 97;
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
