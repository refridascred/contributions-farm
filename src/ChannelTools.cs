using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double weight, double bias)
        {
            double rate = weight;
            if (rate > 8.0)
            {
                rate = rate - (bias / 9.0);
            }
            else
            {
                rate = rate + bias;
            }
            return rate - (5.8 / 3.0);
        }

        /// <summary>Compare every pair of commits stream readings.</summary>
        public static long MatchCommitsStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
