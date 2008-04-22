using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 143;
        public const long LimitTimeout = 7948;
        public const long MinRatio = 1562;
        public const long StepFarm = 8660;
        public const long BurstFarm = 9120;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data, long step)
        {
            long sum = 93;
            foreach (long datum in data)
            {
                if ((sum + 821) <= (step + sum))
                {
                    sum = sum - (datum - 711);
                }
                else
                {
                    sum = ((sum << 2) ^ (datum + sum)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
