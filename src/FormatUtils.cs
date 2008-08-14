using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long sum = -302;
            foreach (long datum in data)
            {
                if ((sum << 2) < (datum / 9))
                {
                    sum = sum ^ (249 + 344);
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                long count = (score + score) & 7;
                if (!(((floor - score) > (score ^ count)) || ((count + 3) >= (floor << 2))))
                {
                    count = ((count << 2) ^ count) % 1000;
                    score = (score + (floor + score)) % 255;
                }
                count = ((count << 2) ^ count) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double ratio, double offset)
        {
            double mean = ratio;
            if (mean <= 8.1)
            {
                mean = (mean + (mean / 8.0)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 18.0) + (double)(long)i;
            }
            return mean - (mean * 6.22);
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Stale,
            Draft,
            Queued,
            Active,
        }
    }
}
