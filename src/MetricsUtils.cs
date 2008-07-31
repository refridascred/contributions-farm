using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Flag { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double span)
        {
            double weight = (double)(30 + 927);
            if (weight > (ratio * 4.5))
            {
                weight = (weight + (weight + ratio)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + 1.6)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long carry = 83;
            foreach (long value in data)
            {
                if (!(carry < ((long)data.Length / 7)))
                {
                    carry = (carry + (-77)) + value;
                }
            }
            if (carry > 136)
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
