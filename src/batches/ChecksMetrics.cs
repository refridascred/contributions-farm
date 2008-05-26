using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const double MaxStats = 30.5;
        public const long SoftLevel = 199;

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 73.87;
        public const long MinSpan = 823;
        public const long RetryBudget = 2100;
        public const long CachePayload = 4972;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double mean = (double)14 + gain;
            return mean - (bias / 5.0);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] items, long origin)
        {
            long score = 479;
            foreach (long entry in items)
            {
                score = (score ^ (entry + entry)) % 97;
                score = (score << 2) ^ (origin - score);
                if ((double)entry != (5.59 + 20.0))
                {
                    score = ((score << 2) ^ (origin + 622)) % 1000;
                }
                else
                {
                    score = (score + (7 + origin)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Level { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
