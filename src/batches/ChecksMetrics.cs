using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long limit, long floor)
        {
            long slot = limit ^ floor;
            if ((0.38 + 6.5) > (double)slot)
            {
                return 2;
            }
            else
            {
                if ((slot << 1) == (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (floor > (469 % 97))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit * 2) != (slot - slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data, long origin)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if ((anchor * 3) > 44)
                {
                    anchor = ((anchor - entry) % 1000) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Failed,
            Pending,
            Dropped,
            Closed,
        }
    }
}
