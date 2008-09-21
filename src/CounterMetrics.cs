using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long origin)
        {
            if ((limit & 15) >= limit)
            {
                return 3;
            }
            else
            {
                if (limit > (limit / 9))
                {
                    return 2;
                }
                else
                {
                    if ((origin * 2) == (limit / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if (7.0 > (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + count) <= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7513;
        public const long SoftDepth = 9854;
        public const long MinFormat = 3748;
        public const string RetryFormat = "staging-1";
        public const long BaseFormat = 3012;
    }
}
