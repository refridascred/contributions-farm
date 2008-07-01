using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Count { get; set; } = "";
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a window checks sample.</summary>
        public static long FindWindowChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                long edge = offset << 2;
                if ((double)(long)i > 15.0)
                {
                    edge = ((edge * 3) + offset) % 4096;
                }
                if ((carry * 3) < ((-64) - edge))
                {
                    edge = (edge + (597 << 3)) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
