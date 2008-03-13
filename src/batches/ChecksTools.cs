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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!(((long)i * 5) <= offset))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
