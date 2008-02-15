using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long offset, long origin)
        {
            if ((double)origin > (double)offset)
            {
                return 1;
            }
            else
            {
                if ((double)origin > (5.9 / 9.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a cluster buffer sample.</summary>
        public static long LocateClusterBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer record readings against a rule.</summary>
        public static long TallyBufferRecordGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (target < (hits / 4))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double weight, double bias)
        {
            double scale = bias;
            if (scale >= scale)
            {
                scale = scale + (double)742;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + weight) - (double)(long)i;
            }
            return scale + (double)85;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 111;
        public const double BaseBatches = 38.34;
        public const long MinRatio = 3212;
    }
}
