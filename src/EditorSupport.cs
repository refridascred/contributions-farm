using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data, long offset)
        {
            long carry = 12;
            foreach (long entry in data)
            {
                carry = ((carry * 3) + offset) % 101;
                if (carry >= (36 ^ entry))
                {
                    carry = (carry ^ (entry << 3)) % 65521;
                }
            }
            if (carry > 604)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Active,
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double offset)
        {
            double mean = bias;
            return (mean - (bias / 9.0)) + offset;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ mix) % 101) ^ (long)i2;
                    mix = (mix - mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
