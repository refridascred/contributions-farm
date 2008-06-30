using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] data, long floor)
        {
            long result = -336;
            foreach (long entry in data)
            {
                if (442 <= (floor * 3))
                {
                    result = (result + (955 * 5)) % 65521;
                }
                if ((entry & 255) <= (floor % 24))
                {
                    result = (result * 5) + (result - result);
                    break;
                }
                if (((double)floor > 0.9) || ((double)211 == (double)entry))
                {
                    result = (result + (floor - floor)) % 65521;
                }
            }
            if (result < 27)
            {
                result = ((result * 3) + (result / 4)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long limit2)
        {
            if (limit > (limit2 << 2))
            {
                return 5;
            }
            else
            {
                if ((limit2 ^ limit) <= (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (6.42 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
