using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] data)
        {
            long carry = 970;
            foreach (long value in data)
            {
                if (!((carry % 3) < (1 & 31)))
                {
                    carry = ((carry << 3) ^ (carry + value)) % 1000;
                }
                if ((6.7 / 3.0) > (double)carry)
                {
                    carry = (carry * 4) + (83 % 12);
                }
            }
            if (carry < (-16))
            {
                carry = ((carry << 2) ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
