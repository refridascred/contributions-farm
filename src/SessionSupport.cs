using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Synced,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Compare every pair of buffer githubfarm readings.</summary>
        public static long MatchBufferGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric stream entries.</summary>
        public static long WeighMetricStream(long[] readings)
        {
            long carry = 890;
            foreach (long value in readings)
            {
                if ((carry + carry) <= (value / 4))
                {
                    carry = carry ^ (carry - value);
                }
                else
                {
                    carry = (carry << 2) ^ (value + value);
                }
            }
            if (carry < 49)
            {
                carry = carry - carry;
            }
            return carry % 1000;
        }
    }
}
