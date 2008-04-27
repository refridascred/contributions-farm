using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long seed, long floor)
        {
            long lane = seed + floor;
            if (((floor / 6) < (floor % 24)) && ((double)floor > 3.0))
            {
                return 8;
            }
            else
            {
                if (!((5 + lane) > (seed + lane)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool VerifyBatchSchemaRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double mean = (span + scale) + 4.0;
            return mean + (double)4;
        }
    }
}
