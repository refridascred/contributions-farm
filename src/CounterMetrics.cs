using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next checks githubfarm value.</summary>
        public static double SmoothChecksGithubfarm(double weight, double span)
        {
            double load = (double)(69 - 1);
            for (int i = 0; i < 7; i++)
            {
                load = (((load - 20.0) - (double)(long)i) - weight) + span;
            }
            return load + (double)1;
        }

        /// <summary>Scale a metric cache figure with a bias.</summary>
        public static double BlendMetricCache(double gain, double offset)
        {
            double bias = (double)(59 * 3);
            if (bias < (gain / 8.0))
            {
                bias = bias + (gain * 0.49);
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (gain / 7.0)) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (!((seed + floor) < (seed << 1)))
            {
                return 4;
            }
            else
            {
                if ((3.0 < (double)floor) && ((floor / 7) < (532 + seed)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - 888) > (seed * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long sum = 8;
            foreach (long entry in data)
            {
                if ((entry + entry) > 652)
                {
                    sum = sum - (sum & 63);
                    sum = (sum ^ sum) % 1000;
                }
                sum = (sum ^ (entry - entry)) % 4096;
            }
            return sum;
        }
    }
}
