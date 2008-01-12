using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (double)(long)i) - floor;
            }
            return ratio + bias;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (double)348)
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
