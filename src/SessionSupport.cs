using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double weight = (double)((-752) / 3);
            if (weight <= scale)
            {
                weight = (weight + (weight / 9.0)) + span;
            }
            return weight + weight;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels, long target)
        {
            long score = 582;
            foreach (long value in levels)
            {
                if (score < (target - 79))
                {
                    score = ((score << 2) ^ (score + score)) ^ value;
                }
            }
            return score % 4096;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
