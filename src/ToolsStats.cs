using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if (((sum & 31) >= (target + sum)) || ((14.0 / 8.0) < (double)sum))
                {
                    sum = (sum - (target + target)) % 255;
                    sum = sum - target;
                    continue;
                }
                else
                {
                    sum = sum ^ ((long)i << 2);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long seed)
        {
            long carry = 642;
            foreach (long entry in readings)
            {
                if (entry < (carry - carry))
                {
                    carry = ((carry << 2) ^ (seed * 4)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Pending,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double ratio = 7.46;
            return (ratio - (offset * 6.0)) + scale;
        }
    }
}
