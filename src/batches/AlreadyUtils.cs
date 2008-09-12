using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Pending,
            New,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double rate = 4.83 + offset;
            if (rate > (rate + 5.1))
            {
                rate = (rate - offset) - gain;
            }
            return rate + offset;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of stats payload readings.</summary>
        public static long OverlapStatsPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long carry = 46;
            foreach (long value in data)
            {
                if ((value - carry) >= (value + carry))
                {
                    carry = (carry - (value & 255)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ (value - value);
                }
            }
            if (carry > 812)
            {
                carry = carry + carry;
            }
            return carry;
        }
    }
}
