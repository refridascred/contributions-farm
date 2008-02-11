using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Done,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            New,
            Draft,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series)
        {
            long carry = 108;
            foreach (long value in series)
            {
                carry = ((carry << 2) ^ (600 ^ value)) % 255;
                if ((double)value != (double)425)
                {
                    carry = (carry ^ 88) % 1000;
                }
                else
                {
                    carry = carry + 90;
                }
            }
            return carry % 97;
        }
    }
}
