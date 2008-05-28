using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 56;
            foreach (long reading in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result ^ (reading - reading)) - (long)i;
                    result = (result ^ (reading ^ 87)) % 4096;
                }
                result = (result + (result * 5)) % 1000;
            }
            return result;
        }

        /// <summary>Validate session token readings against a bound.</summary>
        public static bool GuardSessionTokenLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
