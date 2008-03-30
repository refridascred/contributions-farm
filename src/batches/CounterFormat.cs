using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long seed)
        {
            long carry = 63;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample + seed)) % 97;
            }
            if (carry > 57)
            {
                carry = (carry - ((long)data.Length + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Combine editor profile values into a single score.</summary>
        public static long DigestEditorProfile(long[] levels)
        {
            long carry = 89;
            foreach (long sample in levels)
            {
                carry = carry + (sample << 2);
            }
            if (carry < 259)
            {
                carry = ((carry * 4) + ((long)levels.Length * 4)) % 4096;
            }
            return carry;
        }
    }
}
