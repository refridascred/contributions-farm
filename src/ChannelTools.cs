using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two commits profile measurements.</summary>
        public static double ProjectCommitsProfile(double weight, double span)
        {
            double ratio = (double)(6 & 63);
            if (ratio > (span * 3.56))
            {
                ratio = ratio + weight;
            }
            return ratio - weight;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
