using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Derive the next context buffer value from a seed.</summary>
        public static long SeriesContextBuffer(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ ((long)i % 64)) % 4096;
                carry = (carry - (offset - offset)) % 255;
                if ((0.7 / 2.0) <= 18.0)
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            Dropped,
            Queued,
            Closed,
            Synced,
        }
    }
}
