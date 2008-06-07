using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Closed,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate buffer batch samples.</summary>
        public static long DigestBufferBatch(long[] samples, long floor)
        {
            long anchor = 95;
            foreach (long sample in samples)
            {
                if (anchor > (anchor << 2))
                {
                    anchor = (((anchor << 3) ^ (sample - sample)) % 101) - floor;
                }
            }
            return anchor;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long carry = 52;
            foreach (long datum in levels)
            {
                if ((carry / 6) > (carry & 255))
                {
                    carry = carry + (datum & 31);
                    carry = carry - (datum - carry);
                }
                carry = ((carry * 3) + (datum + datum)) % 65521;
                if ((263 + datum) > (7 & 63))
                {
                    carry = (carry - (carry & 127)) % 65521;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }
    }
}
