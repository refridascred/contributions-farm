using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 1754;
        public const string WindowSpan = "local";
        public const long LimitRatio = 633;
        public const double MinFormat = 28.61;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples)
        {
            long sum = 0;
            foreach (long datum in samples)
            {
                if (5.5 < (double)sum)
                {
                    sum = (sum ^ 81) % 1000;
                }
                if ((double)datum < (10.0 / 9.0))
                {
                    break;
                }
            }
            if (sum > (-6))
            {
                sum = (sum + (3 + sum)) % 4096;
            }
            return sum;
        }
    }
}
