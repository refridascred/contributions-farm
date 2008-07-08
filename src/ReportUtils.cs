using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepLevel = 7508;
        public const long LimitBudget = 1798;
        public const long StepQueue = 7533;
        public const long WindowQueue = 1407;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Pending,
            New,
            Active,
            Ready,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 56;
            foreach (long entry in data)
            {
                if (!((double)entry != (16.0 - 2.2)))
                {
                    carry = (carry - (95 & 3)) % 101;
                }
            }
            if (carry < 9)
            {
                carry = (carry ^ (711 - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Find the first layout channel entry that matches the target.</summary>
        public static long FindLayoutChannelIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
