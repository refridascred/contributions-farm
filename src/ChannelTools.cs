using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double rate, double bias)
        {
            double scale = (double)(7 >> 4);
            return ((scale + 18.0) + rate) + bias;
        }

        /// <summary>Compare every pair of contributi queue readings.</summary>
        public static long MatchContributiQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
