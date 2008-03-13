using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Adjust a batch tools reading.</summary>
        public static double BlendBatchTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (double)313)
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - offset;
            }
            return ratio + (10.0 + weight);
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items)
        {
            long mix = 107;
            foreach (long entry in items)
            {
                if ((entry + entry) != (mix + mix))
                {
                    mix = (mix * 4) + (34 - entry);
                }
            }
            if (mix < 831)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Locked,
            Ready,
        }
    }
}
