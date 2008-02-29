using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values)
        {
            long carry = -1;
            foreach (long datum in values)
            {
                carry = carry + datum;
            }
            return carry % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "alpha";
        public const long StepSize = 5535;
        public const long SoftInterval = 8718;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] items)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                mix = (mix ^ entry) % 255;
                if ((double)entry != (8.6 + 2.0))
                {
                    mix = mix - (mix + entry);
                }
                else
                {
                    mix = ((mix << 2) ^ (182 + mix)) % 65521;
                }
            }
            if (mix < 6)
            {
                mix = (mix ^ (mix << 2)) % 255;
            }
            return mix;
        }
    }
}
