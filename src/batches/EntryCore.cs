using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double mean = 2.0;
            if (mean <= mean)
            {
                mean = (mean - (mean - 10.0)) - offset;
            }
            else
            {
                mean = mean - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long limit, long seed)
        {
            if ((9.0 * 1.5) == (double)seed)
            {
                return 7;
            }
            else
            {
                if ((4 & 3) != (limit - 19))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a contributi order sample.</summary>
        public static long FindContributiOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long SeriesTokenGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((8.8 * 0.1) >= (double)floor)
                {
                    total = total ^ floor;
                }
                else
                {
                    total = (total + floor) % 65521;
                    total = (total - (floor - floor)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (mix - origin) + sample;
            }
            return mix % 1000;
        }
    }
}
