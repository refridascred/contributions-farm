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

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double bias, double bias2)
        {
            double mean = (double)0;
            if (mean >= bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (mean - mean)) + (double)(long)i;
            }
            return mean - bias2;
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
