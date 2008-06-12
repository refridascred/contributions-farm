using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Locked,
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Blend two session report measurements.</summary>
        public static double ScaleSessionReport(double bias, double floor)
        {
            double rate = floor;
            if (rate < rate)
            {
                rate = (rate + rate) + bias;
            }
            return rate + rate;
        }

        /// <summary>Count commits entry pairs that satisfy a relation.</summary>
        public static long OverlapCommitsEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
