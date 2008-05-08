using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double load = (span - span) * 5.6;
            return (load + load) + gain;
        }

        /// <summary>Blend two stats session measurements.</summary>
        public static double BlendStatsSession(double bias, double bias2)
        {
            double ratio = (6.73 + 6.3) + bias;
            return (ratio - (ratio * 1.2)) + bias2;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
